using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MIS3033_LC_1115_BradenFisher.Areas.Identity.Data;
using MIS3033_LC_1115_BradenFisher.Data;

// authentication and authorization
// authen: username, password
// author:

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "MIS3033_fish0090_1204";// 
});

var connectionString = builder.Configuration.GetConnectionString
    ("AuthenDbConnectConnection") ?? throw new InvalidOperationException("Connection string " +
    "'AuthenDbConnectConnection' not found.");

builder.Services.AddDbContext<AuthenDbConnect>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddDefaultIdentity<AuthenUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AuthenDbConnect>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = 
ReferenceHandler.IgnoreCycles);

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Home}/{id?}");
app.MapRazorPages();
app.Run();
