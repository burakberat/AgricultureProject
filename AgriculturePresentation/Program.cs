using AgricultureBusinessLayer.Abstract;
using AgricultureBusinessLayer.Concrete;
using AgricultureBusinessLayer.Container;
using AgricultureBusinessLayer.ValidationRules;
using AgricultureDataAccessLayer.Abstract;
using AgricultureDataAccessLayer.Concrete.EntityFramework;
using AgricultureDataAccessLayer.Contexts;
using AgricultureEntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AgricultureContext>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AgricultureContext>();

builder.Services.ContainerDependencies();

builder.Services.AddMvc(confing =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    confing.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
    {
        x.LoginPath = "/Login/Index/";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();