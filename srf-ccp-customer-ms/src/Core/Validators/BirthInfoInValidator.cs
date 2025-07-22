using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;
using System;

namespace Core.Validators.Customer;

public class BirthInfoInValidator : AbstractValidator<BirthInfoInModel>
{
    private object MessageValidateConst;

    public BirthInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.BirthDay)
                .InclusiveBetween(1, 31).WithMessage("BirthDay must be between 1 and 31.");

        RuleFor(x => x.BirthMonth)
            .InclusiveBetween(1, 12).WithMessage("BirthMonth must be between 1 and 12.");

        RuleFor(x => x.BirthYear)
            .InclusiveBetween(1900, 2100).WithMessage("BirthYear must be between 1900 and 2100.");

        RuleFor(x => x.BirthCountry)
            .NotEmpty().WithMessage("BirthCountry is required.")
            .MaximumLength(4).WithMessage("BirthCountry must be at most 4 characters.");

        RuleFor(x => x.BirthDepartment)
            .NotEmpty().WithMessage("BirthDepartment is required.")
            .MaximumLength(4).WithMessage("BirthDepartment must be at most 4 characters.");

        RuleFor(x => x.BirthCity)
            .NotEmpty().WithMessage("BirthCity is required.")
            .MaximumLength(4).WithMessage("BirthCity must be at most 4 characters.");
    }
}
