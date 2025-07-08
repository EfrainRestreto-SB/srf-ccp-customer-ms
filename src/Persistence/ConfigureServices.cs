using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Core.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

/// <summary>
/// Configuration options for AWS services.
/// </summary>
public class AwsServiceConfiguration
{
    /// <summary>
    /// Gets or sets the name of the AWS shared credentials profile to use.
    /// If null or empty, the default credential chain will be used (environment variables, EC2 instance profile, etc.).
    /// </summary>
    public string? ProfileName { get; set; }

    /// <summary>
    /// Gets or sets the AWS region endpoint.
    /// </summary>
    public RegionEndpoint Region { get; set; } = RegionEndpoint.USEast1; // Default to USEast1, but allow override
}

public static class ConfigureServices
{
    /// <summary>
    /// Attempts to retrieve AWS credentials from a specified shared credentials profile.
    /// </summary>
    /// <param name="profileName">The name of the AWS profile.</param>
    /// <returns>AWS credentials if found, otherwise null.</returns>
    private static AWSCredentials? GetCredentialsFromProfile(string profileName)
    {
        CredentialProfileStoreChain credentialProfileStoreChain = new();

        if (credentialProfileStoreChain.TryGetAWSCredentials(profileName, out AWSCredentials credentials))
        {
            return credentials;
        }
        return null;
    }

    /// <summary>
    /// Adds application services and configures AWS dependencies based on the provided configuration.
    /// </summary>
    /// <param name="services">The IServiceCollection to add services to.</param>
    /// <param name="awsServiceConfig">The AWS service configuration.</param>
    /// <returns>The updated IServiceCollection.</returns>
    /// <exception cref="ArgumentNullException">Thrown if AWS credentials cannot be obtained.</exception>
    public static IServiceCollection AddApplication(this IServiceCollection services, AwsServiceConfiguration awsServiceConfig)
    {
        // Validate configuration
        if (awsServiceConfig == null)
        {
            throw new ArgumentNullException(nameof(awsServiceConfig), "AWS service configuration cannot be null.");
        }

        AWSCredentials? credentials;

        // Determine how to get credentials based on the provided configuration
        if (!string.IsNullOrEmpty(awsServiceConfig.ProfileName))
        {
            // Use a specific profile if provided
            credentials = GetCredentialsFromProfile(awsServiceConfig.ProfileName);
        }
        else
        {
            // Fallback to the default credential chain (environment variables, EC2 instance profile, etc.)
            credentials = FallbackCredentialsFactory.GetCredentials();
        }

        if (credentials is null)
        {
            throw new ArgumentNullException(nameof(awsServiceConfig.ProfileName), "Unable to obtain AWS Credentials. Ensure profile is configured or environment variables are set.");
        }

        // Create AWSOptions with the determined credentials and region from the config
        AWSOptions awsOptions = new()
        {
            Credentials = credentials,
            Region = awsServiceConfig.Region
        };

        services.AddSingleton(awsOptions);
        services.AddAWSService<IAmazonDynamoDB>(awsOptions);

        // Register application services
        services.AddScoped<ICreateCustomerService, ICreateCustomerService>();

        return services;
    }
}