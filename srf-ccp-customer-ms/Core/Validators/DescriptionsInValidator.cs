using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class DescriptionsInValidator : AbstractValidator<DescriptionInfoInModel>
{
    public DescriptionsInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Office and Identification Descriptions
        RuleFor(x => x.OfficeDescription)
            .MaximumLength(100).WithMessage("Office description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.OfficeDescription));

        RuleFor(x => x.IdTypeDescription)
            .MaximumLength(50).WithMessage("ID type description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.IdTypeDescription));

        RuleFor(x => x.IdCountryDescription)
            .MaximumLength(50).WithMessage("Country description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.IdCountryDescription));

        // Personal Descriptions
        RuleFor(x => x.NationalityDescription)
            .MaximumLength(50).WithMessage("Nationality description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.NationalityDescription));

        RuleFor(x => x.EducationDescription)
            .MaximumLength(50).WithMessage("Education description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.EducationDescription));

        // Business Descriptions
        RuleFor(x => x.ActivityDescription)
            .MaximumLength(100).WithMessage("Activity description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.ActivityDescription));

        RuleFor(x => x.RiskDescription)
            .MaximumLength(50).WithMessage("Risk description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.RiskDescription));

        RuleFor(x => x.SectorDescription)
            .MaximumLength(100).WithMessage("Sector description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.SectorDescription));

        // Officer and Entity Descriptions
        RuleFor(x => x.CommercialOfficerDescription)
            .MaximumLength(100).WithMessage("Officer description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.CommercialOfficerDescription));

        RuleFor(x => x.EntityDescription)
            .MaximumLength(100).WithMessage("Entity description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.EntityDescription));

        // Business Type Descriptions
        RuleFor(x => x.BusinessTypeDescription)
            .MaximumLength(100).WithMessage("Business type description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.BusinessTypeDescription));

        RuleFor(x => x.SegmentDescription)
            .MaximumLength(50).WithMessage("Segment description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.SegmentDescription));

        // Additional Descriptions
        RuleFor(x => x.ContractDescription)
            .MaximumLength(50).WithMessage("Contract description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.ContractDescription));

        RuleFor(x => x.Transaction1Description)
            .MaximumLength(100).WithMessage("Transaction description must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.Transaction1Description));

        RuleFor(x => x.NichoDescription)
            .MaximumLength(50).WithMessage("Nicho description must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.NichoDescription));
    }
}