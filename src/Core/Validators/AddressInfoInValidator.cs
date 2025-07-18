using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class AddressInfoInValidator : AbstractValidator<AddressInfoIn>
{
    public AddressInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Address Lines Validation
        RuleFor(x => x.addressLine1)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(100).WithMessage("Address line 1 must be 100 characters or less")
            .Matches(@"^[a-zA-Z0-9\s\-\.,#]+$").WithMessage("Address line 1 contains invalid characters");

        RuleFor(x => x.addressLine2)
            .MaximumLength(100).WithMessage("Address line 2 must be 100 characters or less")
            .Matches(@"^[a-zA-Z0-9\s\-\.,#]*$").WithMessage("Address line 2 contains invalid characters")
            .When(x => !string.IsNullOrEmpty(x.addressLine2));

        RuleFor(x => x.addressLine3)
            .MaximumLength(100).WithMessage("Address line 3 must be 100 characters or less")
            .Matches(@"^[a-zA-Z0-9\s\-\.,#]*$").WithMessage("Address line 3 contains invalid characters")
            .When(x => !string.IsNullOrEmpty(x.addressLine3));

        // Location Validation
        RuleFor(x => x.city)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(50).WithMessage("City must be 50 characters or less");

        RuleFor(x => x.cityCode)
            .MaximumLength(10).WithMessage("City code must be 10 characters or less");

        RuleFor(x => x.country)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(3).WithMessage("Country code must be 3 characters or less");

        RuleFor(x => x.postalCode)
            .MaximumLength(20).WithMessage("Postal code must be 20 characters or less")
            .Matches(@"^[a-zA-Z0-9\-]*$").WithMessage("Postal code contains invalid characters");

        // Residence Information
        RuleFor(x => x.residenceCountry)
            .MaximumLength(3).WithMessage("Residence country code must be 3 characters or less");

        RuleFor(x => x.currentResidenceYears)
            .InclusiveBetween(0, 100).WithMessage("Residence years must be between 0 and 100");

        RuleFor(x => x.currentResidenceMonths)
            .InclusiveBetween(0, 11).WithMessage("Residence months must be between 0 and 11");

        // Housing Type
        RuleFor(x => x.housingType)
            .MaximumLength(2).WithMessage("Housing type must be 2 characters or less");
    }
}