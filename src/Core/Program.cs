using Application;
using Core;
using Microsoft.OpenApi.Models;
using Persistence;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Cargar configuración según el entorno
configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// Registrar capas
builder.Services.AddControllers(); // Requerido para API
builder.Services.AddPersistence(configuration); // Kafka, DynamoDB, Redis, etc.
builder.Services.AddApplication(builder.Environment.EnvironmentName); // Lógica de negocio
builder.Services.AddCore(configuration); // Servicios, Mappers, Validadores

// Configurar Swagger (documentación de API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Customer API",
        Version = "v1",
        Description = "API para gestión de creación de clientes",
    });
});

// Configurar CORS (permite todas las conexiones, puede ajustarse)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

WebApplication app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Customer API V1");
    });
}

app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers(); // Habilita rutas de controladores

await app.RunAsync();
