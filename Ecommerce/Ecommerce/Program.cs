//using Ecommerce.Client.Pages;
//using Ecommerce.Components;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorComponents()
//    .AddInteractiveWebAssemblyComponents();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseWebAssemblyDebugging();
//}
//else
//{
//    app.UseExceptionHandler("/Error", createScopeForErrors: true);
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();

//app.UseStaticFiles();
//app.UseAntiforgery();

//app.MapRazorComponents<App>()
//    .AddInteractiveWebAssemblyRenderMode()
//    .AddAdditionalAssemblies(typeof(Ecommerce.Client._Imports).Assembly);

//app.Run();

using Ecommerce.Client;
using ECommerce.Service.API.AuthService; // Make sure namespace is correct
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root component, mapping to <div id="app"> in index.html
builder.RootComponents.Add<App>("#app");

// Register HttpClient with your API base address
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://ecomm-intern-demo.onrender.com/api") });

// Register your authentication service and custom AuthStateProvider
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthStateProvider>();

// Necessary for Blazor authentication/authorization
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

// Register other needed services here if any

// Build and run the WASM application
await builder.Build().RunAsync();
