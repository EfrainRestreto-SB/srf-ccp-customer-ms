using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class ReferenceInValidator : AbstractValidator<ReferenceInModel>
{
    private object MessageValidateConst;

    public ReferenceInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.ReferenceType)
            .NotEmpty().WithMessage("ReferenceType is required.")
            .MaximumLength(1).WithMessage("ReferenceType max length is 1.")
            .Must(v => new[] { "P", "F", "7" }.Contains(v)).WithMessage("ReferenceType must be P, F or 7.");

        RuleFor(x => x.CompanyName)
            .MaximumLength(60).WithMessage("CompanyName max length is 60.")
            .When(x => x.ReferenceType == "7"); // Solo para referencia comercial

        RuleFor(x => x.ContactName)
            .NotEmpty().WithMessage("ContactName is required.")
            .MaximumLength(80).WithMessage("ContactName max length is 80.");

        RuleFor(x => x.FirstLastName)
            .NotEmpty().WithMessage("FirstLastName is required.")
            .MaximumLength(80).WithMessage("FirstLastName max length is 80.");

        RuleFor(x => x.SecondLastName)
            .NotEmpty().WithMessage("SecondLastName is required.")
            .MaximumLength(80).WithMessage("SecondLastName max length is 80.");

        RuleFor(x => x.CountryCode)
            .NotEmpty().WithMessage("CountryCode is required.")
            .MaximumLength(35).WithMessage("CountryCode max length is 35.");

        RuleFor(x => x.DepartmentCode)
            .NotEmpty().WithMessage("DepartmentCode is required.")
            .MaximumLength(4).WithMessage("DepartmentCode max length is 4.");

        RuleFor(x => x.CityCode)
            .NotEmpty().WithMessage("CityCode is required.")
            .MaximumLength(4).WithMessage("CityCode max length is 4.");

        RuleFor(x => x.LandlinePhone)
            .MaximumLength(15).WithMessage("LandlinePhone max length is 15.")
            .Matches(@"^\d*$").WithMessage("LandlinePhone must be numeric.");

        RuleFor(x => x.MobilePhone)
            .MaximumLength(15).WithMessage("MobilePhone max length is 15.")
            .Matches(@"^\d*$").WithMessage("MobilePhone must be numeric.");

        RuleFor(x => x.PhoneExtension)
            .MaximumLength(15).WithMessage("PhoneExtension max length is 15.")
            .Matches(@"^\d*$").When(x => !string.IsNullOrEmpty(x.PhoneExtension)).WithMessage("PhoneExtension must be numeric.");

        RuleFor(x => x.Relationship)
            .NotEmpty().WithMessage("Relationship is required.");
    }
}
