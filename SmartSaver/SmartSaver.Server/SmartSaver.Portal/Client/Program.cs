using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SmartSaver.Portal.Client.Shared.Breadcrumbs;
using SmartSaver.Presentation.Shared.Breadcrumbs;

namespace SmartSaver.Portal.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("SmartSaver.Portal.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("SmartSaver.Portal.ServerAPI"));

            builder.Services.AddApiAuthorization();

            builder.Services.AddScoped<IBreadcrumbService, BreadcrumbService>();

            await builder.Build().RunAsync();
        }
    }
}
