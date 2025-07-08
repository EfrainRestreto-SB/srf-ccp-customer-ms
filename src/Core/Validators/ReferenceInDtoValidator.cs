using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class ReferenceOutDtoValidator : AbstractValidator<ReferenceInDto>
    {
        private readonly object xPhoneDescription;
        private object xDepartmentCode;

        public ReferenceOutDtoValidator()
        {
            RuleFor(x => x.ReferenceType)
                .NotEmpty().WithMessage("ReferenceType is required.");

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("FirstName is required.");

            RuleFor(x => x.SecondName)
                .NotEmpty().WithMessage("SecondName is required.");

            RuleFor(x => x.FirstLastName)
                .NotEmpty().WithMessage("FirstLastName is required.");

            RuleFor(x => x.SecondLastName)
                .NotEmpty().WithMessage("SecondLastName is required.");

            RuleFor(x => x.CountryCode)
                .NotEmpty().WithMessage("CountryCode is required.");

            RuleFor(x => xDepartmentCode)
                .NotEmpty().WithMessage("DepartmentCode is required.");

            RuleFor(x => x.CityCode)
                .NotEmpty().WithMessage("CityCode is required.");

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address is required.");

            RuleFor(x => x.EmailPhoneNumber)
                .NotEmpty().WithMessage("PhoneNumber is required.");

            RuleFor(x => x.PhoneDescription)
                .NotEmpty().WithMessage("PhoneDescription is required.");
        }
    }
}
