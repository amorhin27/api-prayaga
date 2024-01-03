using ApiPrayaga.Infrastucture;
using ApiPrayaga.Application;
using System.Reflection;
using NLog;
using ApiPrayaga.Api.Middleware;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(option =>
{
    //option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Configuration.AddEnvironmentVariables().AddUserSecrets(Assembly.GetExecutingAssembly(), true);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );
});

//builder.Services
//    .AddHttpContextAccessor()
//    .AddAuthorization()
//    .AddAuthentication(JwtBearerDefaults)
//    .AddJwtBearer(options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidateIssuer = true,
//            ValidateAudience = true,
//            ValidateActor = false,
//            ValidateLifetime = true,
//            ValidateIssuerSigningKey = true,
//            ValidateIssuer = builder.Configuration["JwtSettings:Issuer"],
//            ValidateAudience = builder.Configuration["JwtSettings:Audience"],
//            IssuerSigningKeyResolver = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
//        };
//    });

var app = builder.Build();

//NLog
//LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    var appAssembly = Assembly.Load(new AssemblyName(app.Environment.ApplicationName));
    if (appAssembly != null)
    {
        builder.Configuration.AddUserSecrets(appAssembly, optional: true);
    }
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpLogging();

app.UseGlobalExceptionErrorHandler();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
