using Confluent.Kafka;
using System.Text.Json;

namespace Infrastructure.Kafka
{
    public class JsonKafkaDeserializer<T> : IDeserializer<T>
    {
        public T Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
        {
            if (isNull || data.IsEmpty)
                return default;

            try
            {
                var json = System.Text.Encoding.UTF8.GetString(data.ToArray());
                return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            catch
            {
                // Opcional: manejar error o registrar logs
                return default;
            }
        }
    }
}
