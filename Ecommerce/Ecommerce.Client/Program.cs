using ECommerce.Service.API.AuthService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri("https://ecomm-intern-demo.onrender.com/api") });

// Register your AuthService
builder.Services.AddScoped<IAuthService, AuthService>();

// Register your custom AuthenticationStateProvider implementation here:
builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthStateProvider>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
