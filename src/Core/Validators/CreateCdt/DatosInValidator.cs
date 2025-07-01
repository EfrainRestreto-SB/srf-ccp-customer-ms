using Domain.Constants;
using Domain.Models.CreateCdt.In;
using FluentValidation;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Core.Validators.CreateCdt;

public partial class DatosInValidator : AbstractValidator<DatosInModel>
{
    public DatosInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(c => c.NumeroCliente)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(nc => nc?.ToString()!.Length <= 9).WithMessage(string.Format(MessageValidateConst.IntegerLessThanOrEqualTo, 9));

        RuleFor(c => c.MontoAperturaCdt)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(ma => MontoAperturaRegex().IsMatch(string.Format(CultureInfo.InvariantCulture, "{0}", ma)))
            .WithMessage(string.Format(MessageValidateConst.CantIntegersDecimals, 13, 2));

        RuleFor(c => c.Duracion)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(validator: new DuracionInValidator()!);

        RuleFor(c => c.FrecuenciaPagoInteres)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(validator: new FrecuenciaPagoInteresInValidator()!);

        RuleFor(c => c.CodigoProducto)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));


        RuleFor(c => c.OrigenDeFondos)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(of => of!.Length <= 4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4))
            .Must(of => CommonValidations.OrigenDeFondosInValidate(of!)).WithMessage(MessageValidateConst.InvalidOrigenDeFondos);

        RuleFor(c => c.FechaVencimiento)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(validator: new FechaVencimientoInValidator()!)
            .Must(d => CommonValidations.FechaValidate((int)d!.Anio!, (int)d.Mes!, (int)d.Dia!)).WithMessage(MessageValidateConst.InvalidFecha);

        RuleFor(c => c.DestinoIntereses)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(di => di.ToString()!.Length <= 12).WithMessage(string.Format(MessageValidateConst.IntegerLessThanOrEqualTo, 12));

        RuleFor(c => c.CentroDeCostos)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(cc => cc.ToString()!.Length <= 8).WithMessage(string.Format(MessageValidateConst.IntegerLessThanOrEqualTo, 8));

        RuleFor(c => c.ClaseDeCertificado)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(cc => cc.ToString()!.Length == 1).WithMessage(string.Format(MessageValidateConst.IntegerEqual, 1))
            .Must(cc => CommonValidations.ClaseCertificadoInValidate((int)cc!)).WithMessage(MessageValidateConst.InvalidClaseDeCertificado);
    }

    [GeneratedRegex(@"^\d{1,13}(\.\d{1,2})?$")]
    private static partial Regex MontoAperturaRegex();
}