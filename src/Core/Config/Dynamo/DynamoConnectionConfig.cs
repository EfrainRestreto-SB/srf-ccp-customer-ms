using Core.Config.SettingFiles.Dynamo;
using Core.Interfaces.Configuration;
using Microsoft.Extensions.Options;

namespace Core.Config.Dynamo
{
    public class DynamoConnectionConfig : IDynamoConnectionConfig
    {
        private readonly DynamoJson _config;

        public DynamoConnectionConfig(IOptions<DynamoJson> options)
        {
            _config = options.Value;
        }

        public string Region => throw new NotImplementedException();

        public string AccessKey => throw new NotImplementedException();

        public string SecretKey => throw new NotImplementedException();

        public string ServiceURL => throw new NotImplementedException();

        string IDynamoConnectionConfig.TableName => throw new NotImplementedException();

        public string? TableName() => _config.TableName;
    }
}
