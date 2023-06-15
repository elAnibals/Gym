using GymManager.AplicationServices.Cities;
using GymManager.AplicationServices.Equipment;
using GymManager.AplicationServices.Members;
using GymManager.AplicationServices.MembershipTypes;
using GymManager.AplicationServices.Navigation;
using GymManager.Core.Entities;
using GymManager.DataAccess;
using GymManager.DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing;
using MySqlConnector;
using Serilog;
using System.Configuration;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();



string conncectionString = builder.Configuration.GetConnectionString("Default");
//Identity Services
builder.Services.AddDbContext<GymManagerContext>(options =>
    options.UseMySql(conncectionString, ServerVersion.AutoDetect(conncectionString)));

builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/Identity/LogIn");

builder.Host.UseSerilog();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<GymManagerContext>()
    .AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();


//App Services
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMembershipTypesAppService, MembershipTypesAppService>();
builder.Services.AddTransient<ICititesAppService, CitiesAppService>();
//builder.Services.AddTransient<IEquipmentTypesAppService, EquipmentTypesAppService>();   
builder.Services.AddTransient<IMenuAppService, MenuAppService>();



//Repositories
builder.Services.AddTransient<IRepository<int, Member>, MembersRepository>();
builder.Services.AddTransient<IRepository<int, MembershipType>, MembershipTypesRepository>();
builder.Services.AddTransient<IRepository<int, City>, CitiesRepository>();
builder.Services.AddTransient<IRepository<int, EquipmentType>, EquipmentTypesRepository>();


var app = builder.Build();

//ViewsConfig
app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();

//time Culture
var defaultDateCulture = "es-MX";
var ci = new CultureInfo(defaultDateCulture);
app.UseRequestLocalization(new RequestLocalizationOptions{
    DefaultRequestCulture = new RequestCulture(ci),
    SupportedCultures = new List<CultureInfo> { ci },
    SupportedUICultures= new List<CultureInfo> { ci }
});


//autentication
app.UseAuthentication();
app.UseAuthorization();

//Init Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
