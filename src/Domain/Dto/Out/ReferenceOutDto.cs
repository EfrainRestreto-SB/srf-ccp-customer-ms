namespace Domain.Dto.Out
{
    public class ReferenceOutDto
    {
        public readonly object SecondName;
        public readonly object FirstLastName;
        public object FirstName;
        public object SecondLastName;
        public object EmailPhoneNumber;
        public object Address;

        [JsonPropertyName("referenceType")]
        public string ReferenceType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        [JsonPropertyName("secondSurname")]
        public string SecondSurname { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }
        public string CityCode { get; set; }
        public string DepartmentCode { get; set; }
        public string MobilePhone { get; set; }
        public string PhoneDescription { get; set; }
    }
}
