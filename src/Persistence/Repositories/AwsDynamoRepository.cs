using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Core.Interfaces.Configuration;
using Core.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace Persistence.Repositories
{
    public class AwsDynamoRepository : IAwsDynamoRepository
    {
        private readonly IAmazonDynamoDB _dynamoDbClient;
        private readonly IDynamoConnectionConfig _config;
        private readonly ILogger<AwsDynamoRepository> _logger;

        public AwsDynamoRepository(
            IAmazonDynamoDB dynamoDbClient,
            IOptions<IDynamoConnectionConfig> config,
            ILogger<AwsDynamoRepository> logger)
        {
            _dynamoDbClient = dynamoDbClient;
            _config = config.Value;
            _logger = logger;
        }

        public async Task SaveCustomerAsync(string partitionKey, string sortKey, object data)
        {
            var json = JsonSerializer.Serialize(data);
            var request = new PutItemRequest
            {
                TableName = _config.TableName,
                Item = new Dictionary<string, AttributeValue>
                {
                    { "PK", new AttributeValue { S = partitionKey } },
                    { "SK", new AttributeValue { S = sortKey } },
                    { "Data", new AttributeValue { S = json } }
                }
            };

            await _dynamoDbClient.PutItemAsync(request);
            _logger.LogInformation("Customer saved in DynamoDB with PK: {PK}, SK: {SK}", partitionKey, sortKey);
        }

        public async Task<List<string>> GetAllCustomersAsync()
        {
            var request = new ScanRequest
            {
                TableName = _config.TableName
            };

            var result = await _dynamoDbClient.ScanAsync(request);
            return result.Items.Select(item => item["Data"].S).ToList();
        }

        public async Task<string?> GetCustomerAsync(string partitionKey, string sortKey)
        {
            var request = new GetItemRequest
            {
                TableName = _config.TableName,
                Key = new Dictionary<string, AttributeValue>
                {
                    { "PK", new AttributeValue { S = partitionKey } },
                    { "SK", new AttributeValue { S = sortKey } }
                }
            };

            var result = await _dynamoDbClient.GetItemAsync(request);

            if (result.Item != null && result.Item.TryGetValue("Data", out var data))
                return data.S;

            return null;
        }
    }
}
