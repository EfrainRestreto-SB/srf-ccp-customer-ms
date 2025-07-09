using FluentValidation;
using Domain.Dtos.Customer.In;
using Validators.Customer;

namespace Validators.Customer
{
    public class CustomerCreateInDtoValidator : AbstractValidator<CustomerCreateInDto>
    {
        public CustomerCreateInDtoValidator()
        {
            RuleFor(x => x.BasicInformation)
                .NotNull().WithMessage("BasicInformation es obligatorio.")
                .SetValidator(new BasicInformationInDtoValidator());

            RuleFor(x => x.Identification)
                .NotNull().WithMessage("Identification es obligatorio.")
                .SetValidator(new IdentificationInDtoValidator());

            RuleFor(x => x.BirthInfo)
                .NotNull().WithMessage("BirthInfo es obligatorio.")
                .SetValidator(new BirthInfoInDtoValidator());

            RuleFor(x => x.ContactInfo)
                .NotNull().WithMessage("ContactInfo es obligatorio.")
                .SetValidator(new ContactInfoInDtoValidator());

            RuleFor(x => x.AddressInfo)
                .NotNull().WithMessage("AddressInfo es obligatorio.")
                .SetValidator(new AddressInfoInDtoValidator());

           // RuleFor(x => x.FinancialInfo)
              //  .NotNull().WithMessage("FinancialInfo es obligatorio.")
              //  .SetValidator(new FinancialInfoInDtoValidator());

            RuleFor(x => x.EmploymentInfo)
                .NotNull().WithMessage("EmploymentInfo es obligatorio.")
                .SetValidator(new EmploymentInfoInDtoValidator());

            RuleFor(x => x.ForeignCurrencyAccounts)
                .NotNull().WithMessage("ForeignCurrencyAccounts es obligatorio.")
                .NotEmpty().WithMessage("Debe incluir al menos una cuenta en ForeignCurrencyAccounts.")
                .ForEach(x => x.SetValidator(new ForeignCurrencyAccountInDtoValidator()));

            RuleFor(x => x.InterviewInfo)
                .NotNull().WithMessage("InterviewInfo es obligatorio.")
                .SetValidator(new InterviewInfoInDtoValidator());

            RuleFor(x => x.References)
                .NotNull().WithMessage("References es obligatorio.")
                .NotEmpty().WithMessage("Debe incluir al menos una referencia.")
                .ForEach(x => x.SetValidator(new ReferenceInDtoValidator()));

            RuleFor(x => x.DescriptionInfo)
                .NotNull().WithMessage("DescriptionInfo es obligatorio.")
                .SetValidator(new DescriptionInfoInDtoValidator());
        }
    }
}
