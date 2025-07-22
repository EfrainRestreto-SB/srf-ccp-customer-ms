using Core.Config.SettingFiles.Dynamo;
using Domain.Interfaces.Dynamo.Config;
using Microsoft.Extensions.Options;

namespace Core.Config.Dynamo;

public class DynamoConnectionConfig(IOptions<DynamoJson> options) : IDynamoConnectionConfig
{
    private readonly DynamoJson config = options.Value;

    public string? TableName() => config.TableName;
}
