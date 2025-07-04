using System.Text.Json.Serialization;

namespace Domain.Models.Common;

public class RequestModel<T>
{
    [JsonPropertyName("data")]
    public T? Data { get; set; }
}
