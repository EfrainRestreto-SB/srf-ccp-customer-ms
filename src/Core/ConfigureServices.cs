using Application.Services;
using Core.Mappers;
using Core.Validators.CreateCustomer;
using Domain.Interfaces.Services;
using Domain.Models.CreateCustomer.In;
using Domain.Models.CreateCustomer.Out;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class ConfigureServices
{
    public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
    {
        // Servicios
        services.AddScoped<ICreateCustomerService, CreateCustomerService>();

        // AutoMapper Profile
        services.AddAutoMapper(typeof(CreateCustomerMappingsProfile));

        // Validadores
        services.AddScoped<IValidator<CustomerCreateInModel>, CustomerCreateInModelValidator>();
        services.AddScoped<IValidator<BasicInformationInModel>, BasicInformationInDtoValidator>();
        services.AddScoped<IValidator<BirthInfoInModel>, BirthInfoInDtoValidator>();
        services.AddScoped<IValidator<ContactInfoInModel>, ContactInfoInDtoValidator>();
        services.AddScoped<IValidator<DescriptionsInModel>, DescriptionsInDtoValidator>();
        services.AddScoped<IValidator<EmploymentInfoInModel>, EmploymentInfoInDtoValidator>();
        services.AddScoped<IValidator<FinancialInfoInModel>, FinancialInfoInDtoValidator>();
        services.AddScoped<IValidator<ForeignCurrencyInfoInModel>, ForeignCurrencyInfoInDtoValidator>();
        services.AddScoped<IValidator<IdentificationInModel>, IdentificationInDtoValidator>();
        services.AddScoped<IValidator<InterviewInfoInModel>, InterviewInfoInDtoValidator>();
        services.AddScoped<IValidator<BankingInfoInModel>, BankingInfoInDtoValidator>();
        services.AddScoped<IValidator<ReferencesInModel>, ReferencesInDtoValidator>();

        return services;
    }
}
