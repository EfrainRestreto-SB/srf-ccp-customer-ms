namespace Domain.Models.Customer
{
    public class IdentificationOutModel
    {
        public required string Country { get; set; }
        public required string Department { get; set; }
        public required string Municipality { get; set; }
        public required string DocumentNumber { get; set; }
        public required string DocumentType { get; set; }
        public required string ExpeditionDate { get; set; }
        public required string ExpeditionCountry { get; set; }
        public required string ExpeditionDepartment { get; set; }
        public required string ExpeditionCity { get; set; }
    }
}
