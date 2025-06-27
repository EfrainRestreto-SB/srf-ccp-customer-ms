using Application;
using Core;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Persistence;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Cargar configuración según el entorno
configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// Configuración Kestrel (opcional para alta concurrencia)
builder.WebHost.ConfigureKestrel(opts =>
{
    opts.Limits.MaxConcurrentConnections = 100_000;
    opts.Limits.MaxConcurrentUpgradedConnections = 100_000;
    opts.Limits.MaxRequestBodySize = 100_000_000; // 100 MB
});

// Registrar capas
builder.Services.AddControllers(); // ⚠️ NECESARIO
builder.Services.AddPersistence();
builder.Services.AddApplication(builder.Environment.EnvironmentName);
builder.Services.AddCore(configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

// Construcción de la Aplicación
WebApplication app = builder.Build();

// Swagger solo en desarrollo
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseCors("AllowAllOrigins");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

await app.RunAsync();

