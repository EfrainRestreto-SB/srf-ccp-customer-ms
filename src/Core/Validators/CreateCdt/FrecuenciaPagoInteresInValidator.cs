using Domain.Constants;
using Domain.Models.CreateCdt.In;
using FluentValidation;

namespace Core.Validators.CreateCdt;

public class FrecuenciaPagoInteresInValidator: AbstractValidator<FrecuenciaPagoInteresInModel>
{
    public FrecuenciaPagoInteresInValidator()
    {
        Rules();    
    }

    private void Rules()
    {
        RuleFor(d => d.Tiempo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(d => d.ToString()!.Length <= 3).WithMessage(string.Format(MessageValidateConst.IntegerLessThanOrEqualTo, 3));

        RuleFor(d => d.Unidad)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(of => of!.Length <= 1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1))
            .Must(d => CommonValidations.UnidadFrecuenciaPagoInteresInValidate(d!)).WithMessage(MessageValidateConst.InvalidUnidadFrecuenciaPagoInteres);            
    }
}
