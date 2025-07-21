using Domain.Dto.In;
using Domain.Dtos.Customer.In;
using Domain.Models.CreateCustomer.In;
using Domain.Models.Customer.Out;

namespace Domain.Models.Customer.In
{
    public class CreateCustomerOutModel
    {
        public required BasicInformationOutModel BasicInformation { get; set; }

        public required IdentificationOutModel Identification { get; set; }
        public required BirthInfoOutModel BirthInfo { get; set; }
        public required ContactInfoOutModel ContactInfo { get; set; }
        public required AddressInfoOutModel AddressInfoInModel { get; set; }
        public required FinancialInfoOutModel FinancialInfo { get; set; }
        public required EmploymentInfoOutModel EmploymentInfo { get; set; }
        public required ForeignCurrencyInfoOutModel ForeignCurrencyAccount { get; set; }
        public required IdentificationOutModel IdentificationInfo { get; set; }
        public required InterviewInfoOutModel InterviewInfo { get; set; }
        public required ReferenceOutModel reference { get; set; }
        public required DescriptionInfoOutModel DescriptionInfo { get; set; }

        public required BankingInfoOutModel bankingInfo { get; set; }


        public required ForeignCurrencyInfoOutModel foreignCurrencyInfoModel { get; set; }
    }
}
