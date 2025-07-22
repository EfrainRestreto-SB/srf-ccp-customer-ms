using Application;
using Application.Hubs;
using Core;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.Extensions.Options;
using Persistence;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Cargar configuraci�n seg�n el entorno
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

// Agregar capas a la aplicaci�n
builder.Services.AddPersistence();
builder.Services.AddApplication(builder.Environment.EnvironmentName);
builder.Services.AddCore(configuration);
builder.Services.AddCors(options =>
options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

// ==================================
// Construcci�n de la Aplicaci�n
// ==================================
WebApplication app = builder.Build();

app.MapHub<CustomerHub>("/api/v1/createCustomer", o => { o.Transports = HttpTransportType.WebSockets; });

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