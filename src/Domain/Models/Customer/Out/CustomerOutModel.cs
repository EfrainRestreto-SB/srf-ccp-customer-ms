using System.Collections.Generic;

namespace Domain.Models.Customer
{
    public class CustomerModel
    {
        public required string Id { get; set; }
        public required BasicInformationOutModel BasicInformation { get; set; }
        public required IdentificationOutModel Identification { get; set; }
        public required BirthInfoModel BirthInfo { get; set; }
        public required ContactInfoOutModel ContactInfo { get; set; }
        public required AddressInfoModel AddressInfo { get; set; }
        public required FinancialInfoOutModel FinancialInfo { get; set; }
        public required EmploymenInfoOutModel EmploymentInfo { get; set; }
     
        public required InterviewInfoOutModel InterviewInfo { get; set; }
        public required List<ReferenceOutModel> References { get; set; }
        public required DescriptionInfoOutModel DescriptionInfo { get; set; }
        public required string FirstName { get; set; }

        public static implicit operator CustomerModel(void v)
        {
            throw new NotImplementedException();
        }
    }
}
