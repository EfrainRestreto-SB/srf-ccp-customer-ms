using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Application.Services;
using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ConfigureServices
{
    private static AWSCredentials? GetCredentialsByEnvironment(string environment)
    {
        AWSCredentials? awsCredentials;

        if (environment.Equals("Local", StringComparison.OrdinalIgnoreCase))
        {
            // Usa perfil de AWS (debe estar en ~/.aws/credentials o configurado con AWS CLI)
            awsCredentials = ConfigureServicesHelpers.GetCredentialsFromProfile("awsserfinanza");
        }
        else
        {
            // Usa credenciales del entorno (IAM Role, ENV variables, etc.)
            awsCredentials = FallbackCredentialsFactory.GetCredentials();
        }

        if (awsCredentials is null)
            throw new ArgumentNullException(nameof(environment), "No se pudieron obtener las credenciales de AWS.");

        return awsCredentials;
    }

    public static IServiceCollection AddApplication(this IServiceCollection services, string environment)
    {
        AWSOptions awsOptions = new()
        {
            Credentials = GetCredentialsByEnvironment(environment),
            Region = RegionEndpoint.USEast1 // Ajusta según tu región
        };

        services.AddSingleton(awsOptions);
        services.AddAWSService<IAmazonDynamoDB>(awsOptions);

        // Registro de servicios de aplicación relacionados al cliente
        services.AddScoped<ICreateCustomerService, CreateCustomerService>();

        return services;
    }
}
