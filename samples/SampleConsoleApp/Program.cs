using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OASplash.Client;
using OASplash.DependencyInjection;

namespace SampleConsoleApp
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var client = host.Services.GetRequiredService<IUnsplashClient>();
            var results = await client.GetRandomPhotosAsync(query: "forest", count: 5);
            
            foreach (var photo in results)
                Console.WriteLine($"{photo.Id} - {photo.Width}x{photo.Height}");

            return 0;
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureLogging((context, builder) =>
                {
                    builder.ClearProviders();
                    builder.AddConsole();
                    builder.AddDebug();
                    builder.SetMinimumLevel(LogLevel.Debug);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddUnsplashClient(options =>
                    {
                        // TODO replace with developer credentials or bind from configuration
                        // hostContext.Configuration.GetSection("Unsplash").Bind(options);
                        options.AccessKey = "ACCESSKEY";
                        options.SecretKey = "SECRETKEY";
                    });
                });
        }
    }
}