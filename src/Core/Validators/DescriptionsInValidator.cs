using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class DescriptionsInValidator : AbstractValidator<DescriptionsIn>
{
    public DescriptionsInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Office and Identification Descriptions
        RuleFor(x => x.officeDescription)
            .MaximumLength(100).WithMessage("Office description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.officeDescription));

        RuleFor(x => x.idTypeDescription)
            .MaximumLength(50).WithMessage("ID type description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.idTypeDescription));

        RuleFor(x => x.idCountryDescription)
            .MaximumLength(50).WithMessage("Country description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.idCountryDescription));

        // Personal Descriptions
        RuleFor(x => x.nationalityDescription)
            .MaximumLength(50).WithMessage("Nationality description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.nationalityDescription));

        RuleFor(x => x.educationDescription)
            .MaximumLength(50).WithMessage("Education description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.educationDescription));

        // Business Descriptions
        RuleFor(x => x.activityDescription)
            .MaximumLength(100).WithMessage("Activity description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.activityDescription));

        RuleFor(x => x.riskDescription)
            .MaximumLength(50).WithMessage("Risk description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.riskDescription));

        RuleFor(x => x.sectorDescription)
            .MaximumLength(100).WithMessage("Sector description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.sectorDescription));

        // Officer and Entity Descriptions
        RuleFor(x => x.commercialOfficerDescription)
            .MaximumLength(100).WithMessage("Officer description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.commercialOfficerDescription));

        RuleFor(x => x.entityDescription)
            .MaximumLength(100).WithMessage("Entity description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.entityDescription));

        // Business Type Descriptions
        RuleFor(x => x.businessTypeDescription)
            .MaximumLength(100).WithMessage("Business type description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.businessTypeDescription));

        RuleFor(x => x.segmentDescription)
            .MaximumLength(50).WithMessage("Segment description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.segmentDescription));

        // Additional Descriptions
        RuleFor(x => x.contractDescription)
            .MaximumLength(50).WithMessage("Contract description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.contractDescription));

        RuleFor(x => x.transaction1Description)
            .MaximumLength(100).WithMessage("Transaction description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.transaction1Description));

        RuleFor(x => x.nichoDescription)
            .MaximumLength(50).WithMessage("Nicho description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.nichoDescription));
    }
}