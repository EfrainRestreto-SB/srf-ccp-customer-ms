using SrfCcpCustomerMs.Core;
using Microsoft.OpenApi.Models;
using Application.Mappings;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Customer API", Version = "v1" });
});

// Aquí se registran servicios del proyecto
builder.Services.AddProjectServices();

Type type = typeof(CustomerMappingsProfile);

//Type type1 = type;

// Aquí debe ir AutoMapper correctamente
//builder.Services.AddAutoMapper(type1);

var app = builder.Build();

// Middlewares
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Customer API V1");
});

app.UseAuthorization();
app.MapControllers();

app.Run();
