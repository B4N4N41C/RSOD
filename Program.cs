using Microsoft.EntityFrameworkCore;
using RSOD.Models;
using Microsoft.AspNetCore.Identity;
using RSOD.Data;
using RSOD.Areas.Identity.Data;
using OfficeOpenXml;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Add services to the container.

builder.Services.AddDbContext<RSODContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GameInfoDB")));
builder.Services.AddDbContext<GameDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GameInfoDB")));

builder.Services.AddIdentity<RSODUser, IdentityRole>(options =>
options.SignIn.RequireConfirmedAccount = false).
 AddEntityFrameworkStores<RSODContext>();
builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.AccessDeniedPath = new PathString("/Identity/Account/AccessDenied");
    opt.LoginPath = new PathString("/Identity/Account/Login");
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

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
