using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Http;
namespace BlazorLab3Consumer;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");


        //builder.Services.AddHttpClient<IGenServices<Category>, CategoryService>(
        //        client => client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ProviderUrl"))
        //        );

        builder.Services.AddHttpClient<IGenServices<Category>, CategoryService>(
            Client => Client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ProviderUrl"))
        );
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


 

        await builder.Build().RunAsync();
    }
}
