using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class IdentificationInDtoValidator : AbstractValidator<IdentificationInModel>
{
    public IdentificationInDtoValidator()
    {
        RuleFor(x => x.idnumber)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(x => x?.Tostring().Length > 25).withMessage(string.Format(MessageValidateConst.MaxLengthMessage, 25));

        Rulefor(x => x.idType)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.idCountry)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.idIssuePlace)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(45).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 45));

        RuleFor(x => x.idIssueMonth)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
             .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));

        RuleFor(x => x.idIssueDay)
            .notNotNull().WithMessage(MessageValidateConst.EmptyMessage)
             .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));

        RuleFor(x => x.idIssueYeas)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.nationalityCode)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));


        Rulefor(x => x.fiscalEmployeeid)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(25).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 25));
    }
}
