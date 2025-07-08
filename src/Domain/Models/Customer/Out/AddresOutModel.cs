namespace Domain.Models.Customer
{
    public class AddressInfoModel
    {
        public required string AddressLine1 { get; set; }
        public required string AddressLine2 { get; set; }
        public required string City { get; set; }
        public required string Department { get; set; }
        public required string Country { get; set; }
        public required string PostalCode { get; set; }
        public required string AddressType { get; set; }
        public required string ResidenceMunicipality { get; set; }
        public required string ResidenceDepartment { get; set; }
        public required string ResidenceCountry { get; set; }
    }
}
