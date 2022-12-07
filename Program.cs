using Blazored.LocalStorage;
using BlazorPro.BlazorSize;
using cfblazor;
using LiveBlazorWasm.Client.Formula;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;

namespace LiveBlazorWasm.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<ParserService>();

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddMediaQueryService();
            builder.Services.AddResizeListener(options =>
            {
                options.ReportRate = 500;
                options.EnableLogging = true;
                options.SuppressInitEvent = true;
            });
            builder.Services.AddSingleton(serviceProvider =>
                (IJSInProcessRuntime)serviceProvider.GetRequiredService<IJSRuntime>());
            builder.Services.AddSingleton(serviceProvider =>
                (IJSUnmarshalledRuntime)serviceProvider.GetRequiredService<IJSRuntime>());
            var host = builder.Build();
            await host.RunAsync();
        }


    }
}
