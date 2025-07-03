using Domain.Dtos.CreateCustomer.In;
using System.Text.Json.Serialization;

namespace Domain.Dtos
{
    public class CustomerCreateInDtoBase
    {

        [JsonPropertyName("basicInformation")]
        public BasicInformationInDto? BasicInformation { get; set; }

        [JsonPropertyName("contactInfo")]
        public ContactInfoInDto? ContactInfo { get; set; }

        [JsonPropertyName("birthInfo")]
        public BirthInfoInDto? BirthInfo { get; set; }
    }
}