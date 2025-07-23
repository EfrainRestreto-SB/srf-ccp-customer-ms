using Domain.Models.Customer.Out;

namespace Domain.Models;

public class CreateCustomerOutModel
{
 public AddressInfoOutModel ? AddressInfo { get; set; }
    public  BankingInfoOutModel ? BankingInfo { get; set; }
    public BasicInformationOutModel ? BasicInformation { get; set; }
    public ContactInfoOutModel ? ContactInfo { get; set; }
    public DescriptionInfoOutModel? Descriptions { get; set; }
    public EmploymentInfoOutModel ? EmploymentInfo { get; set; }
    public FinancialInfoOutModel ? FinancialInfo { get; set; }
    public ForeignCurrencyInfoOutModel ? ForeignCurrencyInfo { get; set; }
    public IdentificationOutModel ? Identification { get; set; }
    public InterviewInfoOutModel ? InterviewInfo { get; set; }
    public ReferenceOutModel? References { get; set; }
    public BirthInfoOutModel? BirthInfo { get; set; }


}
