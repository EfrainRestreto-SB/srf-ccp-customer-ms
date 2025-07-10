using Domain.Dto.In;
using Domain.Dtos.Customer.In;

namespace Domain.Models.Customer.In
{
    public class CreateCustomerInModel
    {
        public required BasicInformationInModel BasicInformation { get; set; }

        public required IdentificationInModel Identification { get; set; }
        public required BirthInfoInModel BirthInfo { get; set; }
        public required ContactInfoInModel ContactInfo { get; set; }
        public required AddressInfoInModel AddressInfoInModel { get; set; }
        public required FinancialInfoModel FinancialInfo { get; set; }
        public required EmploymentInfoInModel EmploymentInfo { get; set; }
        public required foreignCurrencyInfoModel ForeignCurrencyAccount { get; set; }
        public required IdentificationInModel IdentificationInfo { get; set; }
        public required InterviewInfoInModel InterviewInfo { get; set; }
        public required ReferenceInModel     reference { get; set; }
        public required DescriptionInfoInModel DescriptionInfo { get; set; }

        public required bankingInfoInModel bankingInfo { get; set; }

        public required FinancialInfoModel  financialInfoModel { get; set; }

        public required  foreignCurrencyInfoModel  foreignCurrencyInfoModel { get; set; }
}
}
