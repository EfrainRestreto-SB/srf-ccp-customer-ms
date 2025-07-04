using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ContactInfoInDtoValidator : AbstractValidator<ContactInfoInModel>
{
    public ContactInfoInDtoValidator()
    {
       RuleFor(x => x.emailType)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(X=> X.email)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .EmailAddress().WithMessage("El correo no es válido.")
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 60));

        RuleFor(x => x.phoneType)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 60));

        RuleFor(x => x.phoneExtencion)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(10).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 10));
    }
}
