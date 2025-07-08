using Confluent.Kafka;
using System.Text;
using System.Text.Json;

namespace Infrastructure.Kafka
{
    public class JsonKafkaSerializer<T> : ISerializer<T>
    {
        public byte[] Serialize(T data, SerializationContext context)
        {
            if (data == null)
            {
                return null;
            }

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false
            });

            return Encoding.UTF8.GetBytes(json);
        }
    }
}
