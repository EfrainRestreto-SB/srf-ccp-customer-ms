using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class EmploymentInfoOuDto
    {
        [JsonPropertyName("employmentStatus")]
        public required string EmploymentStatus { get; set; }

        [JsonPropertyName("employmentType")]
        public required string EmploymentType { get; set; }

        [JsonPropertyName("occupation")]
        public required string Occupation { get; set; }

        [JsonPropertyName("jobTitle")]
        public required string JobTitle { get; set; }

        [JsonPropertyName("profession")]
        public required string Profession { get; set; }

        [JsonPropertyName("sector")]
        public required string Sector { get; set; }

        [JsonPropertyName("companyName")]
        public required string CompanyName { get; set; }

        [JsonPropertyName("companyType")]
        public required string CompanyType { get; set; }

        [JsonPropertyName("contractType")]
        public required string ContractType { get; set; }

        [JsonPropertyName("startDate")]
        public required string StartDate { get; set; }

        [JsonPropertyName("country")]
        public required string Country { get; set; }

        [JsonPropertyName("department")]
        public required string Department { get; set; }

        [JsonPropertyName("city")]
        public required string City { get; set; }
    }
}
