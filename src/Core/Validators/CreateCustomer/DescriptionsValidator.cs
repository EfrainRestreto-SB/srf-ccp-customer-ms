using Application.DTOs.Customer;
using FluentValidation;

namespace Application.Validators.Customer;

public class DescriptionsInDtoValidator : AbstractValidator<DescriptionsInDto>
{
    public DescriptionsInDtoValidator()
    {
        RuleForEachProperty();
    }

    private void RuleForEachProperty()
    {
        RuleFor(x => x.OfficeDescription)
            .NotEmpty().WithMessage("Office description is required.")
            .MaximumLength(45).WithMessage("Max 45 characters.");

        RuleFor(x => x.IdTypeDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.IdCountryDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.NationalityDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.ChannelDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.EducationDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.ActivityDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.RiskDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.SectorDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.ResidenceCountryDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.CommercialOfficerDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.SecondaryOfficerDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.EntityDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.BusinessTypeDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.SegmentDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.DegreeDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.DepartmentDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.PositionDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.ContractDescription)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.Transaction1Description)
            .NotEmpty().MaximumLength(45);

        RuleFor(x => x.NichoDescription)
            .NotEmpty().MaximumLength(45);
    }
}
