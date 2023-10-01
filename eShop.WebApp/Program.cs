using eShop.ApiIntegration;
using eShop.ViewModels.System.Users;
using eShop.WebApp.LocalizationResources;
using FluentValidation;
using FluentValidation.AspNetCore;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
var cultures = new[]
    {
        new CultureInfo("en"),
        new CultureInfo("vi"),
    };

builder.Services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();

builder.Services.AddControllersWithViews()
    .AddExpressLocalization<ExpressLocalizationResource, ViewLocalizationResource>(ops =>
    {
        // When using all the culture providers, the localization process will
        // check all available culture providers in order to detect the request culture.
        // If the request culture is found it will stop checking and do localization accordingly.
        // If the request culture is not found it will check the next provider by order.
        // If no culture is detected the default culture will be used.

        // Checking order for request culture:
        // 1) RouteSegmentCultureProvider
        //      e.g. http://localhost:1234/tr
        // 2) QueryStringCultureProvider
        //      e.g. http://localhost:1234/?culture=tr
        // 3) CookieCultureProvider
        //      Determines the culture information for a request via the value of a cookie.
        // 4) AcceptedLanguageHeaderRequestCultureProvider
        //      Determines the culture information for a request via the value of the Accept-Language header.
        //      See the browsers language settings

        // Uncomment and set to true to use only route culture provider
        ops.UseAllCultureProviders = false;
        ops.ResourcesPath = "LocalizationResources";
        ops.RequestLocalizationOptions = o =>
        {
            o.SupportedCultures = cultures;
            o.SupportedUICultures = cultures;
            o.DefaultRequestCulture = new RequestCulture("vi");
        };
    });

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
 .AddCookie(options =>
 {
     options.LoginPath = "/Account/Login";
     options.AccessDeniedPath = "/User/Forbidden/";
 });

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<ISlideApiClient, SlideApiClient>();
builder.Services.AddTransient<IProductApiClient, ProductApiClient>();
builder.Services.AddTransient<ICategoryApiClient, CategoryApiClient>();
builder.Services.AddTransient<IUserApiClient, UserApiClient>();
builder.Services.AddTransient<IOrderApiClient, OrderApiClient>();

builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseSession();

app.UseRequestLocalization();

app.MapRazorPages();

app.MapControllerRoute(
        name: "Product Category En",
        pattern: "{culture}/categories/{id}", new
        {
            controller = "Product",
            action = "Category"
        });

app.MapControllerRoute(
  name: "Product Category Vn",
  pattern: "{culture}/danh-muc/{id}", new
  {
      controller = "Product",
      action = "Category"
  });

app.MapControllerRoute(
   name: "List Product in Cart En",
   pattern: "{culture}/cart", new
   {
       controller = "Cart",
       action = "Index"
   });

app.MapControllerRoute(
    name: "List Product in Cart Vn",
    pattern: "{culture}/gio-hang", new
    {
        controller = "Cart",
        action = "Index"
    });

app.MapControllerRoute(
   name: "List Product En",
   pattern: "{culture}/products", new
   {
       controller = "Product",
       action = "Category"
   });

app.MapControllerRoute(
    name: "List Product Vn",
    pattern: "{culture}/san-pham", new
    {
        controller = "Product",
        action = "Category"
    });

app.MapControllerRoute(
    name: "Product Detail En",
    pattern: "{culture}/products/{id}", new
    {
        controller = "Product",
        action = "Detail"
    });

app.MapControllerRoute(
  name: "Product Detail Vn",
  pattern: "{culture}/san-pham/{id}", new
  {
      controller = "Product",
      action = "Detail"
  });

app.MapControllerRoute(
     name: "default",
     pattern: "{culture=vi}/{controller=Home}/{action=Index}/{id?}");

app.Run();