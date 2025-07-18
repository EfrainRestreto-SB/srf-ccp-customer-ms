using Domain.Dto.In;
using Domain.Dtos.Customer.In;
using Domain.Models.CreateCdt.In;

namespace Domain.Models.Customer.In
{
    public class CreateCustomerInModel
    {
        public required BasicInformationInModel BasicInformation { get; set; }

        public required IdentificationInModel Identification { get; set; }
        public required BirthInfoInModel BirthInfo { get; set; }
        public required ContactInfoInModel ContactInfo { get; set; }
        public required AddressInfoInModel AddressInfoInModel { get; set; }
        public required FinancialInfoInModel FinancialInfo { get; set; }
        public required EmploymentInfoInModel EmploymentInfo { get; set; }
        public required ForeignCurrencyInfoInModel ForeignCurrencyAccount { get; set; }
        public required IdentificationInModel IdentificationInfo { get; set; }
        public required InterviewInfoInModel InterviewInfo { get; set; }
        public required ReferenceInModel     reference { get; set; }
        public required DescriptionInfoInModel DescriptionInfo { get; set; }

        public required BankingInfoInModel bankingInfo { get; set; }


        public required ForeignCurrencyInfoInModel foreignCurrencyInfoModel { get; set; }
}
}
