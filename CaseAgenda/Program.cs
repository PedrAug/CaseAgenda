using CaseAgenda.Authentication;
using CaseAgenda.Data;
using CaseAgenda.Factory;
using CaseAgenda.Singleton;
using CaseAgenda.Store;
using CaseProject.Repository;
using CaseProject.Repository.UserRepository;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthenticationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AlarmFactory>();
builder.Services.AddScoped<AlarmStore>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<DataContext>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<UserAccountService>();
builder.Services.AddSingleton(SingletonManager.Instance);
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
