namespace Domain.Models.Customer
{
    public class EmploymenInfoOutModel
    {
        public required string EmploymentStatus { get; set; }
        public required string EmploymentType { get; set; }
        public required string Occupation { get; set; }
        public required string JobTitle { get; set; }
        public required string Profession { get; set; }
        public required string Sector { get; set; }
        public required string CompanyName { get; set; }
        public required string CompanyType { get; set; }
        public required string ContractType { get; set; }
        public required string StartDate { get; set; }
        public required string Country { get; set; }
        public required string Department { get; set; }
        public required string City { get; set; }
    }
}
