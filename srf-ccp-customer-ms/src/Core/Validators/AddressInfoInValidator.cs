using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public partial class AddressInfoInValidator : AbstractValidator<AddressInfoInModel>
{
    private object MessageValidateConst;

    public AddressInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.AddressLine1)
             .NotEmpty().WithMessage("AddressLine1 is required.")
             .MaximumLength(45).WithMessage("AddressLine1 must be at most 45 characters.");

        RuleFor(x => x.AddressLine2)
            .MaximumLength(45).WithMessage("AddressLine2 must be at most 45 characters.");

        RuleFor(x => x.AddressLine3)
            .MaximumLength(45).WithMessage("AddressLine3 must be at most 45 characters.");

        RuleFor(x => x.City)
            .NotEmpty().WithMessage("City is required.")
            .MaximumLength(35).WithMessage("City must be at most 35 characters.");

        RuleFor(x => x.CityCode)
            .NotEmpty().WithMessage("CityCode is required.")
            .MaximumLength(4).WithMessage("CityCode must be at most 4 characters.");

        RuleFor(x => x.Country)
            .NotEmpty().WithMessage("Country is required.")
            .MaximumLength(35).WithMessage("Country must be at most 35 characters.");

        RuleFor(x => x.PostalCode)
            .MaximumLength(15).WithMessage("PostalCode must be at most 15 characters.");

        RuleFor(x => x.ResidenceCountry)
            .NotEmpty().WithMessage("ResidenceCountry is required.")
            .MaximumLength(4).WithMessage("ResidenceCountry must be at most 4 characters.");

        RuleFor(x => x.CurrentResidenceYears)
            .InclusiveBetween(0, 99).WithMessage("CurrentResidenceYears must be between 0 and 99.");

        RuleFor(x => x.CurrentResidenceMonths)
            .InclusiveBetween(0, 11).WithMessage("CurrentResidenceMonths must be between 0 and 11.");

        RuleFor(x => x.HousingType)
            .NotEmpty().WithMessage("HousingType is required.")
            .MaximumLength(1).WithMessage("HousingType must be at most 1 character.")
            .Must(x => x == "P" || x == "A" || x == "F" || x == "O")
            .WithMessage("HousingType must be one of the following values: P, A, F, O.");
    }
}