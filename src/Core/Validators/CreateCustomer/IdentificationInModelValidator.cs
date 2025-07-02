using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class IdentificationInDtoValidator : AbstractValidator<IdentificationInModel>
{
    public IdentificationInDtoValidator()
    {
        RuleFor(x => x.DocumentType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.DocumentNumber)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
