using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class IdentificationInValidator : AbstractValidator<IdentificationIn>
{
    public IdentificationInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Core Identification
        RuleFor(x => x.idNumber)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 20));

        RuleFor(x => x.idType)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        // Country Information
        RuleFor(x => x.idCountry)
            .MaximumLength(3).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 3));

        RuleFor(x => x.nationalityCode)
            .MaximumLength(3).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 3));

        // Issue Information
        RuleFor(x => x.idIssuePlace)
            .MaximumLength(50).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 50));

        RuleFor(x => x.idIssueMonth)
            .InclusiveBetween(1, 12).WithMessage(MessageValidateConst.InvalidMonth);

        RuleFor(x => x.idIssueDay)
            .InclusiveBetween(1, 31).WithMessage(MessageValidateConst.InvalidDay);

        RuleFor(x => x.idIssueYear)
            .InclusiveBetween(1900, DateTime.Now.Year).WithMessage(string.Format(MessageValidateConst.YearBetween, 1900, DateTime.Now.Year));

        // Fiscal Information
        RuleFor(x => x.fiscalEmployeeId)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 20));
    }
}