namespace Domain.Models.CreateCustomer.Out;

public class CustomerCreateInModel
{
    public string? Id { get; set; }

    public BasicInformationOutModel? BasicInformation { get; set; }
    public IdentificationOutModel? Identification { get; set; }
    public BirthInfoOutModel? BirthInfo { get; set; }
    public ContactInfoOutModel? ContactInfo { get; set; }
    public FinancialInfoOutModel? FinancialInfo { get; set; }
    public EmploymentInfoOutModel? EmploymentInfo { get; set; }
    public ForeignCurrencyInfoOutModel? ForeignCurrencyInfo { get; set; }
    public InterviewInfoOutModel? InterviewInfo { get; set; }
    public ReferencesOutModel? References { get; set; }
    public DescriptionsOutModel? Descriptions { get; set; }
    public BankingInfoOutModel? BankingInfo { get; set; }
}
