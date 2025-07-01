
namespace Application
{
    internal class CredentialProfileStoreChain
    {
        internal bool TryGetAWSCredentials(string profileName, out object credentials)
        {
            throw new NotImplementedException();
        }

        internal bool TryGetAWSCredentials(string profileName, out AWSCredentials credentials)
        {
            throw new NotImplementedException();
        }
    }
}