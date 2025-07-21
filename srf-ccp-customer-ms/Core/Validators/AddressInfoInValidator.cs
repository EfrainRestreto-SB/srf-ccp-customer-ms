using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class AddressInfoInValidator : AbstractValidator<AddressInfoInModel>
{
    private object MessageValidateConst;

    public AddressInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Address Lines Validation
        RuleFor(x => x.AddressLine1)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(100).WithMessage("Address line 1 must be 100 characters or less")
            .Matches(@"^[a-zA-Z0-9\s\-\.,#]+$").WithMessage("Address line 1 contains invalid characters");

        RuleFor(x => x.AddressLine2)
            .MaximumLength(100).WithMessage("Address line 2 must be 100 characters or less")
            .Matches(@"^[a-zA-Z0-9\s\-\.,#]*$").WithMessage("Address line 2 contains invalid characters")
            .When(x => !string.IsNullOrEmpty(x.AddressLine2));

        RuleFor(x => x.AddressLine3)
            .MaximumLength(100).WithMessage("Address line 3 must be 100 characters or less")
            .Matches(@"^[a-zA-Z0-9\s\-\.,#]*$").WithMessage("Address line 3 contains invalid characters")
            .When(x => !string.IsNullOrEmpty(x.AddressLine3));

        // Location Validation
        RuleFor(x => x.City)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(50).WithMessage("City must be 50 characters or less");

        RuleFor(x => x.CityCode)
            .MaximumLength(10).WithMessage("City code must be 10 characters or less");

        RuleFor(x => x.Country)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(3).WithMessage("Country code must be 3 characters or less");

        RuleFor(x => x.PostalCode)
            .MaximumLength(20).WithMessage("Postal code must be 20 characters or less")
            .Matches(@"^[a-zA-Z0-9\-]*$").WithMessage("Postal code contains invalid characters");

        // Residence Information
        RuleFor(x => x.ResidenceCountry)
            .MaximumLength(3).WithMessage("Residence country code must be 3 characters or less");

        RuleFor(x => x.CurrentResidenceYears)
            .InclusiveBetween(0, 100).WithMessage("Residence years must be between 0 and 100");

        RuleFor(x => x.CurrentResidenceMonths)
            .InclusiveBetween(0, 11).WithMessage("Residence months must be between 0 and 11");

        // Housing Type
        RuleFor(x => x.HousingType)
            .MaximumLength(2).WithMessage("Housing type must be 2 characters or less")
            .Matches(@"^[a-zA-Z]+$").WithMessage("Housing type contains invalid characters");
    }
}