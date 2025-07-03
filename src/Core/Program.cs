using Application;
using Application.Hubs;
using Core;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.Extensions.Options;
using Persistence;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Cargar configuración según el entorno
configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
configuration.AddEnvironmentVariables();
// =======================

builder.WebHost.ConfigureKestrel(opts =>
{
    opts.Limits.MaxConcurrentConnections = 100_000;
    opts.Limits.MaxConcurrentUpgradedConnections = 100_000;
    opts.Limits.MaxRequestBodySize = 100_000_000; // 100 MB
});

// Agregar capas a la aplicación
builder.Services.AddPersistence();
builder.Services.AddApplication(builder.Environment.EnvironmentName);
builder.Services.AddCore(configuration);
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

// ==================================
// Construcción de la Aplicación
// ==================================
WebApplication app = builder.Build();

app.MapHub<SimulationHub>("/api/v1/simulation", o => { o.Transports = HttpTransportType.WebSockets; });
app.MapHub<CdtHub>("/api/v1/createcdt", o => { o.Transports = HttpTransportType.WebSockets; });

// Swagger
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

await app.RunAsync();