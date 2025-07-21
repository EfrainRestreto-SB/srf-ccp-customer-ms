namespace Domain.Interfaces.Dynamo.Config;
public interface IDynamoConnectionConfig
{
    public string? TableName();
}
