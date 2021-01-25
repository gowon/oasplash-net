namespace OASplash.DependencyInjection
{
    using System;
    using System.Net.Http;
    using Abstractions;
    using Client;
    using Extensible;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUnsplashClient(this IServiceCollection services,
            UnsplashBearerTokenFactory bearerTokenFactory,
            Action<UnsplashOptions> configureOptions = null)
        {
            services.Configure(configureOptions); // TODO add default to pull options from configuration
            services.AddSingleton(provider => provider.GetRequiredService<IOptions<UnsplashOptions>>().Value);

            services.AddSingleton(_ => bearerTokenFactory); //TODO add default to throw exception when not set
            services.AddHttpClient<IUnsplashUserAuthorizationClient, UnsplashUserAuthorizationClient>();
            services.AddTransient<UnsplashAuthenticationHandler>();

            services.AddHttpClient<IUnsplashClient, UnsplashClient>()
                .AddHttpMessageHandler<UnsplashAuthenticationHandler>();

            services.AddScoped<IUnsplashClient, UnsplashClient>(provider =>
            {
                var httpClient = provider.GetRequiredService<IHttpClientFactory>()
                    .CreateClient(nameof(IUnsplashClient));

                var options = provider.GetRequiredService<UnsplashOptions>();

                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                httpClient.DefaultRequestHeaders.Add("Accept-Version", options.Version);

                var client = new UnsplashClient(NoopCredentials.Instance, httpClient, false)
                {
                    BaseUri = new Uri(options.BaseUri)
                };

                return client;
            });

            return services;
        }
    }
}