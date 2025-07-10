namespace Domain.Dto.In
{
    public class EmploymentInfoDto
    {
        public object CompanyNit;
        public object JobAddress;
        public object EmploymentStatus;
        public object Phone;
        public object EconomicActivity;
        public object EconomicSector;
        public object EmploymentType;
        public object JobTitle;
        public object EmploymentContractType;

        public required string CompanyName { get; set; }
        public required string companyAddress { get; set; }
        public required string jobPosition { get; set; }
        public required string previousCompany { get; set; }
        public required string employmentStartMonth { get; set; }
        public required string employmentStartDay { get; set; }
        public required string employmentStartYear { get; set; }
        public required string companyCityCode { get; set; }
        public required string companyCountry { get; set; }
        public required string contractType { get; set; }
        public required string departmentCode { get; set; }
        public required string workPhone { get; set; }
        public required string workExtension { get; set; }
        public required string previousJobYears { get; set; }

        public required string previousJobMonths { get; set; }

        public required string employeesCount { get; set; }

        public required string occupationCode { get; set; }
        public required string dependentsCount { get; set; }


    }
}
