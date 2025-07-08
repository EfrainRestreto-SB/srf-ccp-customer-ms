namespace Domain.Models.Customer
{
    public class ReferenceOutModel
    {
        public required string ReferenceType { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string SecondSurname { get; set; }
        public required string CountryCode { get; set; }
        public required string Department { get; set; }
        public required string CityCode { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string PhoneDescription { get; set; }
    }
}
