using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Application;
using Application.Services;
using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    internal static class ConfigureServicesHelpers
    {
        // Obtener credenciales AWS desde perfil local
        private static AWSCredentials? GetCredentialsFromProfile(string profileName)
        {
            CredentialProfileStoreChain credentialProfileStoreChain = new();

            if (credentialProfileStoreChain.TryGetAWSCredentials(profileName, out AWSCredentials credentials))
                return credentials;

            return null;
        }
    // Obtener credenciales AWS desde perfil local
    private static AWSCredentials? GetCredentialsFromProfile(string profileName)
    {
        CredentialProfileStoreChain credentialProfileStoreChain = new();

        if (credentialProfileStoreChain.TryGetAWSCredentials(profileName, out AWSCredentials credentials))
            return credentials;

        return null;
    }
    }
}