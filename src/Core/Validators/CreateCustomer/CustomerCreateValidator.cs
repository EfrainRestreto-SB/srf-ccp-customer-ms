using Core.Validators.CreateCustomer;
using Domain.Constants;
using FluentValidation;

public class CustomerCreateValidator : AbstractValidator<CustomerCreateInModel>
{
    public CustomerCreateValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .EmailAddress().WithMessage("El correo no es válido.");

        RuleFor(x => x.BasicInformation)
            .SetValidator(new BasicInformationInDtoValidator());
    }
}
