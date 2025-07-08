using System.Collections.Generic;

namespace Domain.Dto.In
{
    public class CustomerCreateOutDto
    {
        public required object Addresses;
        public required object ContactInformation;
        public required object Descriptions;

        public required BasicInformationOutDto BasicInformation { get; set; }
        public required IdentificationOutDto Identification { get; set; }
        public required BirthInfoOutDto BirthInfo { get; set; }
        public required ContactInfoOutDto ContactInfo { get; set; }
        public required AddressInfoOutDto AddressInfo { get; set; }
        public required FinancialInfoOutDto FinancialInfo { get; set; }
        public required EmploymentInfoOutDto EmploymentInfo { get; set; }
       
        public required InterviewInfoOutDto InterviewInfo { get; set; }
        public required List<ReferenceOutDto> References { get; set; }
        public required DescriptionInfoOutDto DescriptionInfo { get; set; }
    }
}
