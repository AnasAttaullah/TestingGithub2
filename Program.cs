using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;
using EventEase.Services;
using Microsoft.Extensions.DependencyInjection; // Add this line to fix AddSingleton error

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register EventService as a singleton
builder.Services.AddSingleton<EventService>();
// Register UserSessionService as scoped (per user session)
builder.Services.AddScoped<UserSessionService>();
// Register AttendanceService as singleton (shared across app)
builder.Services.AddSingleton<AttendanceService>();

await builder.Build().RunAsync();
