using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class IdentificationInValidator : AbstractValidator<IdentificationInModel>
{
    private object MessageValidateConst;

    public IdentificationInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Core Identification
        RuleFor(x => x.IdNumber)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 20));

        RuleFor(x => x.IdType)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        // Country Information
        RuleFor(x => x.IdCountry)
            .MaximumLength(3).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 3));

        RuleFor(x => x.NationalityCode)
            .MaximumLength(3).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 3));

        // Issue Information
        RuleFor(x => x.IdIssuePlace)
            .MaximumLength(50).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 50));

        RuleFor(x => x.IdIssueMonth)
            .InclusiveBetween(1, 12).WithMessage(MessageValidateConst.InvalidMonth);

        RuleFor(x => x.IdIssueDay)
            .InclusiveBetween(1, 31).WithMessage(MessageValidateConst.InvalidDay);

        RuleFor(x => x.IdIssueYear)
            .InclusiveBetween(1900, DateTime.Now.Year).WithMessage(string.Format(MessageValidateConst.YearBetween, 1900, DateTime.Now.Year));

        // Fiscal Information
        RuleFor(x => x.FiscalEmployeeId)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 20));
    }
}