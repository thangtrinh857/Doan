using Microsoft.EntityFrameworkCore;
using MediatR;
using Accessories.Data.Context;
using Microsoft.AspNetCore.Identity;
using Accessories.Data;
using Accessories.Domain.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("ConnectionStrings") ?? throw new InvalidOperationException("Connection string 'MyDbContextConnection' not found.");
builder.Services.AddDbContextFactory<AccessoriesDbContext>(options =>
                options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<UserEntity>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AccessoriesDbContext>();
builder.Services.AddScoped(x => x.GetRequiredService<IDbContextFactory<AccessoriesDbContext>>().CreateDbContext());

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});
builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    //options.Cookie.HttpOnly = true;
    //options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.LoginPath = "/Identity/Account/Login";
    //options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    //options.SlidingExpiration = true;
});
//builder.Services.AddControllersWithViews().AddRazorPagesOptions(options => {
//    options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", "");
//});
// Add services to the container.
builder.Services.AddMediatR(typeof(Program));
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseRequestLocalization();
app.UseEndpoints(c =>
{
    c.MapRazorPages();
    //c.MapDefaultControllerRoute();
    c.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();