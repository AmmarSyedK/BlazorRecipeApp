using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RecipeApp;
using Blazored.LocalStorage;
using Blazorise;
using Blazorise.Material;
using Blazorise.Icons.Material;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services
    .AddBlazorise( options =>
    {
        options.Immediate = true;
    } )
    .AddMaterialProviders()
    .AddMaterialIcons();

await builder.Build().RunAsync();