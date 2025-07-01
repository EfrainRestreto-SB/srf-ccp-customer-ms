using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.CreateCustomer.In
{
    internal class EmploymentInfoDto
    {
        [JsonPropertyName("companyName")]
        public string? comanyName { get; set; }

        [JsonPropertyName("companyAdress")]
        public string? companyAdress { get; set; }

        [JsonPropertyName("jobPosition")]
        public string? jobPosition { get; set; }

        [JsonPropertyName("previusCompany")]
        public string? previusCompany { get; set; }

        [JsonPropertyName("employmentStartMonth")]
        public string? employmentStartMonth { get; set; }

        [JsonPropertyName("employmentStartDay")]
        public string? employmentStartDay { get; set; }

        [JsonPropertyName("employmentStartYears")]
        public string? employmentStartYears { get; set; }

        [JsonPropertyName("companyCityCode")]
        public string? comapanyCityCode { get; set; }

        [JsonPropertyName("companycountry")]
        public string? companyCountry { get; set; }

        [JsonPropertyName("contracType")]
        public string? contractType { get; set; }

        [JsonPropertyName("departamenCode")]
        public string? DepartamentCode { get; set; }

        [JsonPropertyName("workCode")]
        public string? workCode { get; set; }

        [JsonPropertyName("workPhone")]
        public string? workPhone { get; set; } 
        
        [JsonPropertyName("workExtencion")]
        public string? workExtencion { get; set; }

        [JsonPropertyName("previousJobYears")]
        public string? previousJobYears { get; set; }

        [JsonPropertyName("previousJobMonth")]
        public string? previousJobMonth { get; set; }

        [JsonPropertyName("employeesCount")]
        public string? employessCount { get; set; }

        [JsonPropertyName("ocupationCode")]
        public string? ocupationCode { get; set; }

        [JsonPropertyName("dependentsCounts")]
        public string? dependentsCounts { get; set; }
    }
}
