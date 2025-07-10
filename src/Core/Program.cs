using Application.Mappings;
using Core.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SrfCcpCustomerMs.Application.Services;
using SrfCcpCustomerMs.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Customer API", Version = "v1" });
});

builder.Services.AddScoped<ICreateCustomerService, CustomerService>();

builder.Services.AddAutoMapper(typeof(CustomerMappingsProfile));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Customer API V1");
});

app.UseAuthorization();
app.MapControllers();
app.Run();
