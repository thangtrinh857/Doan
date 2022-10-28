using Microsoft.EntityFrameworkCore;
using MediatR;
using Accessories.Data.Context;
using Microsoft.AspNetCore.Identity;
using Accessories.Data;
using Accessories.Domain.Models;
using Accessories.Mapper;
using Accessories.ServicesAgent.Services.CartProductCommand;
using Accessories.Infrastructure.Interfaces.CartProductCommand;
using Accessories.Infrastructure.Interfaces.Payment;
using Accessories.ServicesAgent.Services.Payment;
using Accessories.Infrastructure.Interfaces.ProductCommand;
using Accessories.ServicesAgent.Services.ProductCommand;
using Accessories.Infrastructure.Interfaces.CategoryCommand;
using Accessories.ServicesAgent.Services.CategoryCommand;
using Accessories.Infrastructure.Interfaces.API.RegionCommand;
using Accessories.ServicesAgent.Services.API.RegionCommand;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("ConnectionStrings") ?? throw new InvalidOperationException("Connection string 'MyDbContextConnection' not found.");
builder.Services.AddDbContextFactory<AccessoriesDbContext>(options =>
                options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<UserEntity>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AccessoriesDbContext>();
builder.Services.AddScoped(x => x.GetRequiredService<IDbContextFactory<AccessoriesDbContext>>().CreateDbContext());
builder.Services.AddAutoMapper(typeof(MappingProfile));
// Add service, interface
builder.Services.AddTransient<ICartProductService, CartProductService>();
builder.Services.AddTransient<IPaymentService, PaymentService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IRegionAPIService, RegionAPIService>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
});
builder.Services.AddRazorPages();
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
app.UseHttpsRedirection();
app.UseEndpoints(c =>
{
    c.MapRazorPages();
    //c.MapDefaultControllerRoute();
    c.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
