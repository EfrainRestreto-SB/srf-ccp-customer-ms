using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class IdentificationInValidator : AbstractValidator<IdentificationInModel>
{

    public IdentificationInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.IdNumber)
                .NotEmpty().WithMessage("IdNumber is required.")
                .MaximumLength(25);

        RuleFor(x => x.IdType)
            .NotEmpty().WithMessage("IdType is required.")
            .MaximumLength(4);

        RuleFor(x => x.IdCountry)
            .NotEmpty().WithMessage("IdCountry is required.")
            .MaximumLength(4);

        RuleFor(x => x.IdIssuePlace)
            .NotEmpty().WithMessage("IdIssuePlace is required.")
            .MaximumLength(45);

        RuleFor(x => x.IdIssueMonth)
            .InclusiveBetween(1, 12).WithMessage("IdIssueMonth must be between 1 and 12.");

        RuleFor(x => x.IdIssueDay)
            .InclusiveBetween(1, 31).WithMessage("IdIssueDay must be between 1 and 31.");

        RuleFor(x => x.IdIssueYear)
            .InclusiveBetween(1900, 2100).WithMessage("IdIssueYear must be a valid year.");

        RuleFor(x => x.NationalityCode)
            .NotEmpty().WithMessage("NationalityCode is required.")
            .MaximumLength(4);

        RuleFor(x => x.FiscalEmployeeId)
            .MaximumLength(25);
    }
}


