using Domain.Dto.In;
using System.Collections.Generic;

namespace Domain.Dto.Out
{
    public class CustomerCreateOutDto
    {
        public BasicInformationOutDto BasicInformation { get; set; }
        public IdentificationOutDto Identification { get; set; }
        //public required BirthInfoOutDto BirthInfo { get; set; }
        public ContactInfoOutDto ContactInfo { get; set; }
        public AddressInfoOutDto AddressInfo { get; set; }
        public FinancialInfoOutDto FinancialInfo { get; set; }
        public EmploymentInfoOutDto EmploymentInfo { get; set; }
        public ForeignCurrencyAccountOutDto ForeignCurrencyAccount { get; set; }
        public InterviewInfoOutDto InterviewInfo { get; set; }
        public List<ReferenceOutDto> References { get; set; }
        public DescriptionInfoOutDto DescriptionInfo { get; set; }
    }
}
