namespace SampleConsoleApp
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Net.Http;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using OASplash.Client;
    using OASplash.DependencyInjection;
    using OASplash.Extensible;

    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var client = host.Services.GetRequiredService<IUnsplashClient>();
            var results = await client.GetRandomPhotosAsync(query: "forest", count: 5);

            foreach (var photo in results)
                Console.WriteLine($"{photo.Id} - {photo.Width}x{photo.Height}");
            
            var me = await client.GetCurrentUserAsync();
            Console.WriteLine($"{me.FirstName} {me.LastName} , {me.TotalLikes}");

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
                    services.AddUnsplashClient(BearerTokenFactory, options =>
                    {
                        options.AccessKey = "ACCESS_KEY";
                        options.SecretKey = "SECRET_KEY";
                    });
                });
        }

        internal static async Task<string> BearerTokenFactory(IUnsplashUserAuthorizationClient authorizationClient,
            HttpRequestMessage request,
            HttpResponseMessage response, CancellationToken cancellationToken = default)
        {
            // ask for all scopes
            var scopes = Enum.GetValues(typeof(AuthorizationScope)).Cast<AuthorizationScope>().ToArray();
            var url = authorizationClient.GenerateUserAuthorizationUrl(scopes);

            // open Authorization URL in browser to get the authorization code
            Console.WriteLine($"Launching '{url}'");
            OpenBrowser(url);
            Console.WriteLine("Please type in authorization code from browser:");
            var authorizationCode = Console.ReadLine();
            
            //use authorization code to get bearer token
            var authResponse = await authorizationClient.RequestBearerTokenAsync(authorizationCode, cancellationToken);
            var json = JsonConvert.DeserializeObject<JObject>(await authResponse.Content.ReadAsStringAsync());
            return json["access_token"].ToString();
        }

        internal static void OpenBrowser(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}")
                    {
                        CreateNoWindow = true
                    });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}