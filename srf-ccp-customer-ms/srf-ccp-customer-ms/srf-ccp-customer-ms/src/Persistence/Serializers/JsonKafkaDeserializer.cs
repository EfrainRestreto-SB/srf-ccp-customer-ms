using Confluent.Kafka;
using System.Text;
using System.Text.Json;

namespace Persistence.Serializers;

public class JsonKafkaDeserializer<T> : IDeserializer<T>
{
    public T Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
    {
        if (isNull) return default!;

        string jsonString = Encoding.UTF8.GetString(data);
        return JsonSerializer.Deserialize<T>(jsonString)!;
    }
}
