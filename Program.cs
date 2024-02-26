using Core.Dtos;
using idflNet.auth;
using idflNet.Constants;
using idflNet.Data;
using idflNet.Middlewares;
using idflNet.Repository;
using idflNet.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Services;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddCors();
builder.Services.AddControllers()
 .AddJsonOptions(options =>
  {
      options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
  });
// configure databsae
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppJwtSettings"));
builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = KeyConstant.CsrfHeader;
});
builder.Services.AddScoped<IJwtUtilRepository, JwtUtils>();
builder.Services.AddScoped<IUserRepository, UserService>();
builder.Services.AddTransient<HomeMetaDataService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
//Auth
app.UseAuthentication();
app.UseAuthorization();
//Add Cors
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
//Middleware
MyMiddlewareExtensions.UseMyMiddeware(app);
app.UseMiddleware<LanguageMiddleware>();
app.UseMiddleware<JwtMiddleware>();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

// custom jwt auth middleware
app.Run();
