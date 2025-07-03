using Domain.Constants;
using Domain.Models.CreateCdt.In;
using FluentValidation;

namespace Core.Validators.CreateCdt;

public class DuracionInValidator : AbstractValidator<DuracionInModel>
{
    public DuracionInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(d => d.Tiempo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(d => d.ToString()!.Length <= 5).WithMessage(string.Format(MessageValidateConst.IntegerLessThanOrEqualTo, 5));

        RuleFor(d => d.Unidad)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(of => of!.Length <= 1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1))
            .Must(d => CommonValidations.UnidadDuracionInValidate(d!)).WithMessage(MessageValidateConst.InvalidUnidadDuracion);           
    }
}
