using Domain.Constants;
using Domain.Models.CreateCdt.In;
using FluentValidation;

namespace Core.Validators.CreateCdt;

public class FechaVencimientoInValidator: AbstractValidator<FechaVencimientoInModel>
{
    public FechaVencimientoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(c => c.Dia)
            .NotNull().WithMessage(MessageValidateConst.NullMessage);

        RuleFor(c => c.Mes)
            .NotNull().WithMessage(MessageValidateConst.NullMessage);

        RuleFor(c => c.Anio)
            .NotNull().WithMessage(MessageValidateConst.NullMessage);
    }
}
