using FluentValidation;
using Utils.Validators;

namespace Core.Validators
{
    public class ContactInfoInDtoValidator : AbstractValidator<ContactInformationInDto>
    {
        public ContactInfoInDtoValidator(ContactInformationInDto x)
        {
            RuleFor(x => x.Email)
                .Required("Email")
                .ValidEmail("Email");

           
        }
    }
}
