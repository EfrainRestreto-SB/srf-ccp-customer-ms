using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ContactInfoInDtoValidator : AbstractValidator<ContactInfoInModel>
{
    public ContactInfoInDtoValidator()
    {
        RuleFor(x => x.Email)
            .EmailAddress().WithMessage(MessageValidateConst.InvalidEmail)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
