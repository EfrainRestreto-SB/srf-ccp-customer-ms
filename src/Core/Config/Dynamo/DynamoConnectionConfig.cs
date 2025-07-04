using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Microsoft.Extensions.Options;

namespace Core.Config.Aws;

public class DynamoConnectionConfig
{
    private readonly string _profileName;
    private readonly string _environment;
    private readonly string _region;

    public DynamoConnectionConfig(IOptions<DynamoConnectionSettings> options)
    {
        var config = options.Value;
        _profileName = config.ProfileName ?? "default";
        _environment = config.Environment ?? "Local";
        _region = config.Region ?? "us-east-1";
    }

    public IAmazonDynamoDB CreateClient()
    {
        var credentials = GetCredentials();
        var regionEndpoint = RegionEndpoint.GetBySystemName(_region);
        return new AmazonDynamoDBClient(credentials, regionEndpoint);
    }

    private AWSCredentials GetCredentials()
    {
        if (_environment == "Local")
        {
            var chain = new CredentialProfileStoreChain();
            if (chain.TryGetAWSCredentials(_profileName, out var credentials))
                return credentials;
        }

        return FallbackCredentialsFactory.GetCredentials();
    }
}
