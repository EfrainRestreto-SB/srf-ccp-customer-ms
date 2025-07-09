using Domain.Dto.Out;

namespace Domain.Dto.Out.Customer
{
    public class CustomerCreateOutDto
    {
        public string CustomerId { get; set; } = default!;
        public BasicInformationOutDto BasicInformation { get; set; } = default!;
        public IdentificationOutDto Identification { get; set; } = default!;
       // public BirthInfoOutDto BirthInfo { get; set; } = default!;
        public ContactInfoOutDto ContactInfo { get; set; } = default!;
        public AddressInfoOutDto AddressInfo { get; set; } = default!;
        public FinancialInfoOutDto FinancialInfo { get; set; } = default!;
        public EmploymentInfoOutDto EmploymentInfo { get; set; } = default!;
        public List<ForeignCurrencyAccountOutDto> ForeignCurrencyAccounts { get; set; } = new();
        public InterviewInfoOutDto InterviewInfo { get; set; } = default!;
        public List<ReferenceOutDto> References { get; set; } = new();
        public DescriptionInfoOutDto DescriptionInfo { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Creado";
    }
}
