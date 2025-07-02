using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using Domain.Models.CreateCustomer.Out;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class CustomerCreateInModelValidator : AbstractValidator<CustomerCreateInModel>
{
    public CustomerCreateInModelValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Matches(@"^\d{13,14}$").WithMessage("El campo 'id' debe contener entre 13 y 14 dígitos numéricos.");

        RuleFor(x => x.BasicInformation)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new BasicInformationInDtoValidator());

        RuleFor(x => x.BirthInfo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new BirthInfoInDtoValidator());

        RuleFor(x => x.ContactInfo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new ContactInfoInDtoValidator());

        RuleFor(x => x.Descriptions)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new DescriptionsInDtoValidator());

        RuleFor(x => x.EmploymentInfo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new EmploymentInfoInDtoValidator());

        RuleFor(x => x.FinancialInfo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new FinancialInfoInDtoValidator());

        RuleFor(x => x.ForeignCurrencyInfo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new ForeignCurrencyInfoInDtoValidator());

        RuleFor(x => x.Identification)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new IdentificationInDtoValidator());

        RuleFor(x => x.InterviewInfo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new InterviewInfoInDtoValidator());

        RuleFor(x => x.BankingInfo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new BankingInfoInDtoValidator());

        RuleFor(x => x.References)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new ReferencesInDtoValidator());
    }
}
