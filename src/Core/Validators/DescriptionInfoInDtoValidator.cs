using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class DescriptionInfoInDtoValidator : AbstractValidator<DescriptionInfoInDto>
    {
        public DescriptionInfoInDtoValidator()
        {
            RuleFor(x => x.OfficeDescription)
                .NotEmpty().WithMessage("OfficeDescription is required.");

            RuleFor(x => x.IdentificationDescription)
                .NotEmpty().WithMessage("IdentificationDescription is required.");

            RuleFor(x => x.NationalityDescription)
                .NotEmpty().WithMessage("NationalityDescription is required.");

            RuleFor(x => x.ProfessionDescription)
                .NotEmpty().WithMessage("ProfessionDescription is required.");

            RuleFor(x => x.RiskDescription)
                .NotEmpty().WithMessage("RiskDescription is required.");

            RuleFor(x => x.DisabilityDescription)
                .NotEmpty().WithMessage("DisabilityDescription is required.");

            RuleFor(x => x.ChannelDescription)
                .NotEmpty().WithMessage("ChannelDescription is required.");

            RuleFor(x => x.GeographicLocationDescription)
                .NotEmpty().WithMessage("GeographicLocationDescription is required.");

            RuleFor(x => x.DepartmentDescription)
                .NotEmpty().WithMessage("DepartmentDescription is required.");

            RuleFor(x => x.CityDescription)
                .NotEmpty().WithMessage("CityDescription is required.");

            RuleFor(x => x.MunicipalityDescription)
                .NotEmpty().WithMessage("MunicipalityDescription is required.");

            RuleFor(x => x.ResidenceDescription)
                .NotEmpty().WithMessage("ResidenceDescription is required.");
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
