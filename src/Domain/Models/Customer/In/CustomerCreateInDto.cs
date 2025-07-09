using static Domain.Dtos.Customer.In.CustomerCreateInDto;

namespace Domain.Dto.In
{
    public class CustomerCreateDto
    {
        public BasicInformationInDto BasicInformation { get; set; }
        public IdentificationInDto Identification { get; set; }
        public BirthInfoInDto BirthInfo { get; set; }
        public ContactInfoInDto ContactInfo { get; set; }
        public AddressInfoInDto AddressInfo { get; set; }
        public FinancialInfoDto FinancialInfo { get; set; }
        public EmploymentInfoInDto EmploymentInfo { get; set; }
        public ForeignCurrencyAccountInDto ForeignCurrencyAccount { get; set; }
        public InterviewInfoInDto InterviewInfo { get; set; }
        public List<ReferenceInDto> References { get; set; }
        public DescriptionInfoInDto DescriptionInfo { get; set; }
    }
}
