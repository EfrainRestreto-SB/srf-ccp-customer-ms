using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Application.Services.Customer;
using Application.Interfaces.Customer;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ConfigureServices
{
    private static AWSCredentials? GetCredentialsFromProfile(string profileName)
    {
        CredentialProfileStoreChain chain = new();
        return chain.TryGetAWSCredentials(profileName, out var credentials) ? credentials : null;
    }

    private static AWSCredentials? GetCredentialsByEnvironment(string environment)
    {
        return environment == "Local"
            ? GetCredentialsFromProfile("awsserfinanza")
            : FallbackCredentialsFactory.GetCredentials();
    }

    public static IServiceCollection AddApplication(this IServiceCollection services, string environment)
    {
        var credentials = GetCredentialsByEnvironment(environment)
                          ?? throw new ArgumentNullException(nameof(environment), "Unable to obtain AWS credentials.");

        var awsOptions = new AWSOptions
        {
            Credentials = credentials,
            Region = RegionEndpoint.USEast1
        };

        services.AddSingleton(awsOptions);
        services.AddAWSService<IAmazonDynamoDB>(awsOptions);

        services.AddScoped<ICustomerService, CustomerService>();

        return services;
    }
}
