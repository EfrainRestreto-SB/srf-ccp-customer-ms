using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class BasicInformationInDtoValidator : AbstractValidator<BasicInformationInDto>
    {
        public BasicInformationInDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("FirstName is required.");

            RuleFor(x => x.SecondName)
                .NotEmpty().WithMessage("SecondName is required.");

            RuleFor(x => x.FirstLastName)
                .NotEmpty().WithMessage("FirstLastName is required.");

            RuleFor(x => x.SecondLastName)
                .NotEmpty().WithMessage("SecondLastName is required.");

            RuleFor(x => x.Gender)
                .NotEmpty().WithMessage("Gender is required.");

            RuleFor(x => x.CivilStatus)
                .NotEmpty().WithMessage("CivilStatus is required.");

            RuleFor(x => x.Language)
                .NotEmpty().WithMessage("Language is required.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email format is invalid.");

            RuleFor(x => x.EducationLevel)
                .NotEmpty().WithMessage("EducationLevel is required.");

            RuleFor(x => x.EconomicActivity)
                .NotEmpty().WithMessage("EconomicActivity is required.");

            RuleFor(x => x.EconomicActivityCode)
                .NotEmpty().WithMessage("EconomicActivityCode is required.");

            RuleFor(x => x.RiskCode)
                .NotEmpty().WithMessage("RiskCode is required.");

            RuleFor(x => x.PEPStatus)
                .NotEmpty().WithMessage("PEPStatus is required.");

            RuleFor(x => x.UNHCR)
                .NotEmpty().WithMessage("UNHCR is required.");

            RuleFor(x => x.Disability)
                .NotEmpty().WithMessage("Disability is required.");

            RuleFor(x => x.EthnicGroup)
                .NotEmpty().WithMessage("EthnicGroup is required.");

            RuleFor(x => x.ChannelCode)
                .NotEmpty().WithMessage("ChannelCode is required.");

            RuleFor(x => x.ResidencyCondition)
                .NotEmpty().WithMessage("ResidencyCondition is required.");

            RuleFor(x => x.GeographicLocation)
                .NotEmpty().WithMessage("GeographicLocation is required.");
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
