using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class AddressInfoInDtoValidator : AbstractValidator<AddressInfoInDto>
    {
        public AddressInfoInDtoValidator()
        {
            RuleFor(x => x.AddressLine1)
                .NotEmpty().WithMessage("AddressLine1 is required.");

            RuleFor(x => x.AddressLine2)
                .NotEmpty().WithMessage("AddressLine2 is required.");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("City is required.");

            RuleFor(x => x.Department)
                .NotEmpty().WithMessage("Department is required.");

            RuleFor(x => x.Country)
                .NotEmpty().WithMessage("Country is required.");

            RuleFor(x => x.PostalCode)
                .NotEmpty().WithMessage("PostalCode is required.");

            RuleFor(x => x.ResidenceCountry)
                .NotEmpty().WithMessage("ResidenceCountry is required.");

            RuleFor(x => x.CurrentResidenceYears)
                .NotEmpty().WithMessage("CurrentResidenceYears is required.");

            RuleFor(x => x.PostalType)
                .NotEmpty().WithMessage("PostalType is required.");
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
