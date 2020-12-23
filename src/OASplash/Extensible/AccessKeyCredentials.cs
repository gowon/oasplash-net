using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using OASplash.Abstractions;

namespace OASplash.Extensible
{
    // https://stackoverflow.com/a/37546641/7644876
    public class AccessKeyCredentials : ServiceClientCredentials
    {
        private readonly string _accessKey;

        public AccessKeyCredentials(UnsplashOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.AccessKey))
                throw new InvalidOperationException("Access key cannot be null or empty.");

            _accessKey = options.AccessKey;
        }

        public override async Task ProcessHttpRequestAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Client-ID", _accessKey);
            await base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}