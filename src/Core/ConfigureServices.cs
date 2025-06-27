using SrfCcpCustomerMs.Application.Services;
using SrfCcpCustomerMs.Domain.Interfaces;
using SrfCcpCustomerMs.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace SrfCcpCustomerMs.Core
{
    public static class ConfigureServices
    {
        public static void AddProjectServices(this IServiceCollection services)
        {
            services.AddScoped<CustomerService>();
            services.AddScoped<ICustomerRepository, AwsDynamoCustomerRepository>();
        }
    }
}
