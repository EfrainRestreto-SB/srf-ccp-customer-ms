using Domain.Models.CreateCustomer.In;
using Domain.Models.Customer;

namespace Domain.Models;

public class CreateCustomerInModel 
{
    public BasicInformationInModel? basicInformation { get; set; }
    public IdentificationInModel? identification { get; set; }
    public BirthInfoInModel? birthInfo { get; set; }
    public ContactInfoInModel? contactInfo { get; set; }
    public AddressInfoInModel? addressInfo { get; set; }
    public FinancialInfoInModel? financialInfo { get; set; }
    public EmploymentInfoInModel? employmentInfo { get; set; }
    public ForeignCurrencyInfoInModel? foreignCurrencyInfo { get; set; }
    public BankingInfoInModel? bankingInfo { get; set; }
    public InterviewInfoInModel? interviewInfo { get; set; }
    public ReferenceInModel? references { get; set; }
    public DescriptionInfoInModel? descriptions { get; set; }

}