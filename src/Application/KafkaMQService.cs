using Application.Services;
using Domain.Interfaces.Services;

namespace Application;

public static class ConfigureServices
{
    private static object? FallbackCredentialsFactory;

    public static object? RegionEndpoint { get; private set; }

    private static AWSCredentials? GetCredentialsFromProfile(string profileName)
    {
        CredentialProfileStoreChain credentialProfileStoreChain = new();

        if (!credentialProfileStoreChain.TryGetAWSCredentials(profileName, out AWSCredentials credentials))
            return null;

        return credentials;
    }

    private static AWSCredentials? GetCredentialsByEnvironment(string environment, object? fallbackCredentialsFactory)
    {
        AWSCredentials? aWSCredentials;
        if (environment == "Local")
            aWSCredentials = GetCredentialsFromProfile("awsserfinanza");
        else
            aWSCredentials = fallbackCredentialsFactory.GetCredentials();

        if (aWSCredentials is null)
            throw new ArgumentNullException(nameof(environment), "Unable to obtain AWS Credentials.");

        return aWSCredentials;
    }

    public static IServiceCollection AddApplication(this IServiceCollection services, string environment)
    {
        AWSOptions awsOptions = new() { Credentials = GetCredentialsByEnvironment(environment, FallbackCredentialsFactory), Region = RegionEndpoint.USEast1 };
        services.AddSingleton(awsOptions);
        services.AddAWSService<IAmazonDynamoDB>(awsOptions);

        // REGISTRO DE CUSTOMER SERVICE
        services.AddScoped<Services.ICreateCustomerService, CreateCustomerService>();

        return services;
    }
}

internal class AWSCredentials
{
}