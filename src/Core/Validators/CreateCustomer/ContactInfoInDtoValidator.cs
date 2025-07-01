using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ContactInfoInDtoValidator : AbstractValidator<ContactInfoInModel>
{
    public ContactInfoInDtoValidator()
    {
        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .EmailAddress().WithMessage(MessageValidateConst.InvalidEmail);
    }
}