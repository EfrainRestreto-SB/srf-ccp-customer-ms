using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;
using System.Security.Cryptography.Xml;

namespace Core.Validators.Customer;

public class ReferenceInValidator : AbstractValidator<ReferenceIn>
{
    public ReferenceInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Reference Type Validation
        RuleFor(x => x.referenceType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage("Reference type must be 2 characters or less");

        // Company Information
        RuleFor(x => x.companyName)
            .MaximumLength(100).WithMessage("Company name must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.companyName));

        // Contact Person Validation
        RuleFor(x => x.contactName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage("Contact name must be 60 characters or less");

        RuleFor(x => x.firstLastName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage("Last name must be 60 characters or less");

        RuleFor(x => x.secondLastName)
            .MaximumLength(60).WithMessage("Second last name must be 60 characters or less")
            .When(x => !string.IsNullOrEmpty(x.secondLastName));

        // Location Information
        RuleFor(x => x.countryCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(3).WithMessage("Country code must be 3 characters or less");

        RuleFor(x => x.departmentCode)
            .MaximumLength(10).WithMessage("Department code must be 10 characters or less")
            .When(x => !string.IsNullOrEmpty(x.departmentCode));

        RuleFor(x => x.cityCode)
            .MaximumLength(10).WithMessage("City code must be 10 characters or less")
            .When(x => !string.IsNullOrEmpty(x.cityCode));

        // Contact Information
        RuleFor(x => x.landlinePhone)
            .MaximumLength(15).WithMessage("Landline must be 15 characters or less")
            .Matches(@"^[0-9\+\-\(\)\s]*$").WithMessage("Landline contains invalid characters")
            .When(x => !string.IsNullOrEmpty(x.landlinePhone));

        RuleFor(x => x.mobilePhone)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(15).WithMessage("Mobile must be 15 characters or less")
            .Matches(@"^[0-9\+\-\(\)\s]+$").WithMessage("Mobile contains invalid characters");

        RuleFor(x => x.phoneExtension)
            .MaximumLength(10).WithMessage("Extension must be 10 characters or less")
            .Matches(@"^[0-9]*$").WithMessage("Extension must contain only numbers")
            .When(x => !string.IsNullOrEmpty(x.phoneExtension));

        // Relationship
        RuleFor(x => x.relationship)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage("Relationship code must be 2 characters or less");
    }
}

public class ReferencesInValidator : AbstractValidator<ReferencesIn>
{
    public ReferencesInValidator()
    {
        RuleForEach(x => x.References).SetValidator(new ReferenceInValidator());
    }
}