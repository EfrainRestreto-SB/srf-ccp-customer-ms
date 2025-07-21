using Application;
using Application.Hubs;
using Application.Services;
using Core;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.OpenApi.Models;
using Persistence;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// =======================
// Cargar configuración
// =======================
configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// =======================
// Kestrel Config
// =======================
builder.WebHost.ConfigureKestrel(opts =>
{
    opts.Limits.MaxConcurrentConnections = 100_000;
    opts.Limits.MaxConcurrentUpgradedConnections = 100_000;
    opts.Limits.MaxRequestBodySize = 100_000_000; // 100 MB
});

// =======================
// Servicios
// =======================
builder.Services.AddControllers(); // FALTABA ESTA LÍNEA
builder.Services.AddEndpointsApiExplorer(); // Necesario para Swagger
builder.Services.AddSwaggerGen(c => // FALTABA ESTO
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Customer API",
        Version = "v1",
        Description = "API para crear cuentas CDT en IBM",
    });
});

builder.Services.AddPersistence();
builder.Services.AddApplication(builder.Environment.EnvironmentName);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

// =======================
// App
// =======================
WebApplication app = builder.Build();

// Swagger solo en entornos no productivos
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Customer API V1");
    });
}
else
{
    app.UseHsts();
}

// Middlewares
app.UseCors("AllowAllOrigins");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers(); // Exponer los controladores
app.MapHub<CustomerHub>("/api/v1/createCustomer", o => { o.Transports = HttpTransportType.WebSockets; });

await app.RunAsync();
