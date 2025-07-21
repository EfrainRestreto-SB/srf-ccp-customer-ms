using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Application.Services;
using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Application.Services;

public static class ConfigureServices
{
    private static AWSCredentials? GetCredentialsFromProfile(string profileName)
    {
        CredentialProfileStoreChain credentialProfileStoreChain = new();

        if (credentialProfileStoreChain.TryGetAWSCredentials(profileName, out AWSCredentials credentials))
            return credentials;

        return null;
    }

    private static AWSCredentials? GetCredentialsByEnvironment(string environment)
    {
        AWSCredentials? aWSCredentials;
        if (environment == "Local")
            aWSCredentials = GetCredentialsFromProfile("awsserfinanza");
        else
            aWSCredentials = FallbackCredentialsFactory.GetCredentials();

        if (aWSCredentials is null)
            throw new ArgumentNullException(nameof(environment), "Unable to obtain AWS Credentials.");

        return aWSCredentials;
    }

    public static IServiceCollection AddApplication(this IServiceCollection services, string environment)
    {
        AWSOptions awsOptions = new() { Credentials = GetCredentialsByEnvironment(environment), Region = RegionEndpoint.USEast1 };
        services.AddSingleton(awsOptions);
        services.AddAWSService<IAmazonDynamoDB>(awsOptions);

        services.AddScoped<ICreateCustomerService, CreateCustomerService>();


        return services;
    }
}
