using System.Collections.Generic;

namespace Domain.Models.Customer
{
    public class CustomerOutModel
    {
        public string Id { get; set; }
        public BasicInformationOutModel BasicInformation { get; set; }
        public IdentificationOutModel Identification { get; set; }
        public BirthInfoModel BirthInfo { get; set; }
        public ContactInfoOutModel ContactInfo { get; set; }
        public AddressInfoModel AddressInfo { get; set; }
        public FinancialInfoOutModel FinancialInfo { get; set; }
        public EmploymenInfoOutModel EmploymentInfo { get; set; }
   
        public ForeignCurrencyAccountOutModel ForeignCurrencyAccount { get; set; }
       
        public InterviewInfoOutModel InterviewInfo { get; set; }
        public List<ReferenceOutModel> References { get; set; }
        public DescriptionInfoOutModel DescriptionInfo { get; set; }
    }
}
