using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OASplash.Abstractions;
using OASplash.Client;
using OASplash.Extensible;

namespace OASplash.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUnsplashClient(this IServiceCollection services,
            Action<UnsplashOptions> configureOptions = null)
        {
            services.Configure(configureOptions);
            services.AddSingleton(provider => provider.GetRequiredService<IOptions<UnsplashOptions>>().Value);
            services.AddSingleton<AccessKeyCredentials>();

            services.AddHttpClient<IUnsplashClient, UnsplashClient>();
            services.AddScoped<IUnsplashClient, UnsplashClient>(provider =>
            {
                var httpClient = provider.GetRequiredService<IHttpClientFactory>()
                    .CreateClient(nameof(IUnsplashClient));

                var credentials = provider.GetRequiredService<AccessKeyCredentials>();
                var options = provider.GetRequiredService<UnsplashOptions>();

                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                httpClient.DefaultRequestHeaders.Add("Accept-Version", options.Version);

                var client = new UnsplashClient(credentials, httpClient, false)
                {
                    BaseUri = new Uri(options.BaseUri)
                };

                return client;
            });

            return services;
        }
    }
}