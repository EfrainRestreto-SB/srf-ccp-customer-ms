using Domain.Dto.In;
using Domain.Dtos.Customer.In;

namespace Domain.Models.Customer.In
{
    public class CreateCustomerInModel
    {
        public required BasicInformationDto BasicInformation { get; set; }

        public required IdentificationDto Identification { get; set; }
        public required BirthInfoDto BirthInfo { get; set; }
        public required ContactInfoDto ContactInfo { get; set; }
        public required AddressInfoDto AddressInfoInModel { get; set; }
        public required FinancialInfoModel FinancialInfo { get; set; }
        public required EmploymentInfoDto EmploymentInfo { get; set; }
        public required ForeignCurrencyInfoInDto ForeignCurrencyAccount { get; set; }
        public required InterviewInfoDto InterviewInfo { get; set; }
        public required List<ReferenceDto> References { get; set; }
        public required DescriptionInfoDto DescriptionInfo { get; set; }

        public required BankingInfoInDto BankingInfo { get; set; }
    }
}
