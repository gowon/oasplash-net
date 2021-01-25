namespace OASplash.Extensible
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Abstractions;
    using Microsoft.Extensions.Options;

    public class UnsplashUserAuthorizationClient : IUnsplashUserAuthorizationClient
    {
        private readonly HttpClient _httpClient;
        private readonly UnsplashOptions _options;

        public UnsplashUserAuthorizationClient(HttpClient httpClient, IOptions<UnsplashOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public async Task<HttpResponseMessage> RequestBearerTokenAsync(string authorizationCode,
            CancellationToken cancellationToken = default)
        {
            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_options.OAuthTokenUri)
            };
            // Set Headers

            // Serialize Request
            var values = new List<KeyValuePair<string, string>>
            {
                new("client_id", _options.AccessKey),
                new("client_secret", _options.SecretKey),
                new("redirect_uri", _options.OAuthRedirectUri),
                new("grant_type", "authorization_code"),
                new("code", authorizationCode)
            };

            var formContent = new FormUrlEncodedContent(values);
            httpRequest.Content = formContent;
            cancellationToken.ThrowIfCancellationRequested();
            return await _httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }

        public string GenerateUserAuthorizationUrl(params AuthorizationScope[] scopes)
        {
            var list = new List<AuthorizationScope>(scopes);
            var scopeValue = string.Join("+",
                list.Distinct().Select(permissionScope => permissionScope.ToSerializedValue()));

            var queryParameters = new Dictionary<string, string>
            {
                {"client_id", _options.AccessKey},
                {"redirect_uri", Uri.EscapeUriString(_options.OAuthRedirectUri)},
                {"response_type", "code"},
                {"scope", scopeValue}
            };

            var _builder = new UriBuilder(_options.OAuthAuthorizeUri)
            {
                Query = string.Join("&", queryParameters.Select(pair => $"{pair.Key}={pair.Value}"))
            };

            return _builder.ToString();
        }
    }
}