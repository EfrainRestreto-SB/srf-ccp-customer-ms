using SrfCcpCustomerMs.Core;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Customer API", Version = "v1" });
});

builder.Services.AddProjectServices();

var app = builder.Build();

// Siempre habilita Swagger (HTTP o HTTPS)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Customer API V1");
});

app.UseAuthorization();
app.MapControllers();
app.Run();
