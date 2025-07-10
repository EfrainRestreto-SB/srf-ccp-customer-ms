namespace Domain.Dto.In
{
    public class AddressInfoInModel
    {
        public required string AddressLine1 { get; set; }
        public required string AddressLine2 { get; set; }
        public required string AddressLine3 { get; set; }
        public required string City { get; set; }

        public required  string cityCode { get; set; }
        public required string Country { get; set; }
        public required string PostalCode { get; set; }
        public required string ResidenceCountry { get; set; }
        public required string currentResidenceYears { get; set; }

        public required string currentResidenceMonths { get; set; }
        public required string HousingType { get; set; }
    }
}
