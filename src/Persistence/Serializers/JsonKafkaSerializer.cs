using System.Text;
using System.Text.Json;

namespace Persistence.Serializers;

public class JsonKafkaSerializer<T> : ISerializer<T>
    
{
    public byte[] Serialize(T data, SerializationContext context)
    {
        return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(data));
    }
}
