using HandyWebHelper;
using HandyWebHelper.Interfaces;
using HandyWebHelper.Models;
using HandyWebHelper.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddFluentUIComponents();

builder.Services.AddSingleton<SettingsContainer>();
builder.Services.AddScoped<IClipboardService, ClipboardService>();


await builder.Build().RunAsync();
