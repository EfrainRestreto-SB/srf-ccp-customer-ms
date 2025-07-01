using Domain.Constants;
using Domain.Models.CreateCdt.In;
using FluentValidation;

namespace Core.Validators.CreateCdt;

public class InstruccionVencimientoInValidator : AbstractValidator<InstruccionVencimientoInModel>
{
    public InstruccionVencimientoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(iv => iv.InstruccionProrroga)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(ip => ip!.ToString()!.Length == 1).WithMessage(string.Format(MessageValidateConst.IntegerEqual, 1))
            .Must(ip => CommonValidations.InstruccionProrrogaInValidate(ip!)).WithMessage(MessageValidateConst.InvalidInstruccionProrroga);

        RuleFor(iv => iv.ViaDePago)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(vp => vp!.ToString()!.Length == 1).WithMessage(string.Format(MessageValidateConst.IntegerEqual, 1))
            .Must(vp => CommonValidations.ViaPagoInValidate(vp!)).WithMessage(MessageValidateConst.InvalidViaPago);

        RuleFor(iv => iv.CuentaContableDePago)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(cc => cc!.ToString()!.Length <= 16).WithMessage(string.Format(MessageValidateConst.IntegerLessThanOrEqualTo, 16));
    }
}
