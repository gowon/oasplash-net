namespace OASplash.Extensible
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;
    using Abstractions;
    using Microsoft.Extensions.Options;

    public delegate Task<string> UnsplashBearerTokenFactory(IUnsplashUserAuthorizationClient authorizationClient,
        HttpRequestMessage request,
        HttpResponseMessage response, CancellationToken cancellationToken = default);

    public class UnsplashAuthenticationHandler : DelegatingHandler
    {
        private readonly IUnsplashUserAuthorizationClient _authenticationClient;
        private readonly UnsplashBearerTokenFactory _bearerTokenFactory;
        private readonly UnsplashOptions _options;
        private string _accessToken;

        public UnsplashAuthenticationHandler(IUnsplashUserAuthorizationClient authenticationClient,
            IOptions<UnsplashOptions> options, UnsplashBearerTokenFactory bearerTokenFactory)
        {
            _authenticationClient = authenticationClient;
            _bearerTokenFactory = bearerTokenFactory;
            _options = options.Value;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(_accessToken))
            {
                ApplyClientAuthentication(request);
            }
            else
            {
                ApplyAuthorizationToken(request);
            }

            // Attempt to perform the request
            var response = await base.SendAsync(request, cancellationToken);
            for (var i = 0; i < _options.MaxAuthorizationRetries; i++)
            {
                // if the response is showing an auth error, attempt to get a new auth token
                if (response.StatusCode == HttpStatusCode.Unauthorized ||
                    response.StatusCode == HttpStatusCode.Forbidden)
                {
                    // we need a new bearer token with the necessary scope
                    await GetAuthorizationTokenAsync(request, response, cancellationToken);
                    ApplyAuthorizationToken(request);
                    response = await base.SendAsync(request, cancellationToken);

                    continue;
                }

                break;
            }

            return response;
        }

        private void ApplyClientAuthentication(HttpRequestMessage request)
        {
            if (string.IsNullOrWhiteSpace(_options.AccessKey))
            {
                throw new InvalidOperationException("Access key cannot be null or empty.");
            }

            request.Headers.Authorization = new AuthenticationHeaderValue("Client-ID", _options.AccessKey);
        }

        private void ApplyAuthorizationToken(HttpRequestMessage request)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        }

        private async Task GetAuthorizationTokenAsync(HttpRequestMessage request, HttpResponseMessage response,
            CancellationToken cancellationToken)
        {
            _accessToken = await _bearerTokenFactory(_authenticationClient, request, response, cancellationToken);
        }
    }
}