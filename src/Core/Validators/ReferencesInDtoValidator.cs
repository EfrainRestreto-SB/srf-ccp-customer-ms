using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ReferencesInDtoValidator : AbstractValidator<ReferencesInModel>
{
    public ReferencesInDtoValidator()
    {
        RuleFor(x => x.Nombre)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(100).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 100));

        RuleFor(x => x.Telefono)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Matches(@"^\d{7,15}$").WithMessage("El teléfono debe tener entre 7 y 15 dígitos numéricos.");

        RuleFor(x => x.Relacion)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(50).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 50));
    }
}
