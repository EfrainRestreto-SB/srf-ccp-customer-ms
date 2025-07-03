using Domain.Constants;
using Domain.Models;
using FluentValidation;

namespace Core.Validators.CreateCdt;

public class CreateCdtInValidator : AbstractValidator<CreateCdtInModel>
{
    public CreateCdtInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(c => c.Datos)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(validator: new DatosInValidator()!);

        RuleFor(c => c.InstruccionVencimiento)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(validator: new InstruccionVencimientoInValidator()!);

        RuleFor(c => c.Fondeo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(validator: new FondeoInValidator()!);
    }
}
