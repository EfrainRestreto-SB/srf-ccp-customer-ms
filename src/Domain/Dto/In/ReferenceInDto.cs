using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class ReferenceInDto
    {
        public object PersonType;
        public object FirstName;
        public object PhoneDescription;

        [JsonPropertyName("referenceType")]
        public string ReferenceType { get; set; }              // E1RRTP

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }                 // E1RMA1

        [JsonPropertyName("contactName")]
        public string ContactName { get; set; }                 // E1RNM3

        [JsonPropertyName("firstLastName")]
        public string FirstLastName { get; set; }               // E1RNM4

        [JsonPropertyName("secondLastName")]
        public string SecondLastName { get; set; }              // E1RNM5

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }                 // E1RCTR

        [JsonPropertyName("departmentCode")]
        public string DepartmentCode { get; set; }              // E1RSTE

        [JsonPropertyName("cityCode")]
        public string CityCode { get; set; }                    // E1RMLC

        [JsonPropertyName("landlinePhone")]
        public string LandlinePhone { get; set; }               // E1RHPN

        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }                 // E1RPH2

        [JsonPropertyName("phoneExtension")]
        public string PhoneExtension { get; set; }              // E1RPH3

        [JsonPropertyName("relationship")]
        public string Relationship { get; set; }                // E1RRTL
    }
}
