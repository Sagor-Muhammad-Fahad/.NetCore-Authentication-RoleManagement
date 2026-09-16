using AspDotNetCoreAuthAndAuth.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("con");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.SignIn.RequireConfirmedAccount = false;
})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Accounts/Login";
    options.AccessDeniedPath = "/Accounts/AccessDenied";
});

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default", 
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
