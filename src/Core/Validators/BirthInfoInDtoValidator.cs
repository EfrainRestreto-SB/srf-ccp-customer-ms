using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class ContactInfoOutDtoValidator : AbstractValidator<ContactInfoOutDto>
    {
        public ContactInfoOutDtoValidator()
        {
            RuleFor(x => x.EmailType)
                .NotEmpty().WithMessage("EmailType is required.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email format is invalid.");

            RuleFor(x => x.PhoneType)
                .NotEmpty().WithMessage("PhoneType is required.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("PhoneNumber is required.");

            RuleFor(x => x.PhoneDescription)
                .NotEmpty().WithMessage("PhoneDescription is required.");
        }
    }
}
