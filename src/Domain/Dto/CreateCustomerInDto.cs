using Domain.Dto.In;
using static Domain.Dtos.Customer.In.CustomerCreateInDto;

namespace Domain.Dtos.Customer.In
{
    public class CreateCustomerInDto
    {
        public required BasicInformationInDto BasicInformation { get; set; }
        public required IdentificationInDto Identification { get; set; }
        public required BirthInfoInDto BirthInfo { get; set; }
        public required ContactInfoInDto ContactInfo { get; set; }
        public required AddressInfoInDto AddressInfo { get; set; }
        public required FinancialInfoInDto FinancialInfo { get; set; }
        public required EmploymentInfoInDto EmploymentInfo { get; set; }
        public required ForeignCurrencyInfoInDto ForeignCurrencyAccount { get; set; }
        public required InterviewInfoInDto InterviewInfo { get; set; }
        public required List<ReferenceInDto> References { get; set; }
        public required DescriptionInfoInDto DescriptionInfo { get; set; }

        public required BankingInfoInDto BankingInfo { get; set; }

        public class FinancialInfoInDto
        {
        }
    }
}
