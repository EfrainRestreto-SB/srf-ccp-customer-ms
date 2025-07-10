using FluentValidation;
using Domain.Dto.In;
using Domain.Dtos.Customer.In;

namespace Validators.Customer
{
    public class ContactInfoInDtoValidator : AbstractValidator<ContactInfoInDto>
    {
        public ContactInfoInDtoValidator()
        {
            RuleFor(x => x.EmailType).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.PhoneType).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.PhoneDescription).NotEmpty();
        }
    }
}