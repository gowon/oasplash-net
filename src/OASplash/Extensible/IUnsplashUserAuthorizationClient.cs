namespace OASplash.Extensible
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Abstractions;

    public interface IUnsplashUserAuthorizationClient : IDisposable
    {
        string GenerateUserAuthorizationUrl(params AuthorizationScope[] scopes);

        Task<HttpResponseMessage> RequestBearerTokenAsync(string authorizationCode,
            CancellationToken cancellationToken = default);
    }
}