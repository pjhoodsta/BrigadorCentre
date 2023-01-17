using Microsoft.AspNetCore.Identity;
using BrigadorCentreApp.Data;
using BrigadorCentreApp.Service;
using BrigadorCentreApp.Utility.AppSettingClasses;
using BrigadorCentreApp.Utility.DIConfig;
using BrigadorCentreApp.Service.LifeTimeExample;
using BrigadorCentreApp.Middleware;
using BrigadorCentreApp.Models;
using Microsoft.EntityFrameworkCore;
//https://github.com/dotnet/extensions/issues/2084
using Microsoft.Extensions.DependencyInjection.Extensions;
//https://github.com/andrewlock/NetEscapades.Extensions.Logging/issues/2
using Microsoft.Extensions.Logging;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddAppSettingsConfig(builder.Configuration).AddAllServices();

var app = builder.Build();

//https://stackoverflow.com/questions/69938319/how-to-get-iloggerfactory-in-net-6
var loggerFactory = app.Services.GetRequiredService<ILoggerFactory>();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
loggerFactory.AddFile("logs/creditApp-log-{Date}.txt");
app.UseAuthentication();
app.UseAuthorization();
//app.UseMiddleware<CustomMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
