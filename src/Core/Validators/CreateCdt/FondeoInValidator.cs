using Domain.Constants;
using Domain.Models.CreateCdt.In;
using FluentValidation;
using System.Text.RegularExpressions;


namespace Core.Validators.CreateCdt;

public partial class FondeoInValidator : AbstractValidator<FondeoInModel>
{
    public FondeoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(c => c.Concepto)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .SetValidator(new ConceptoInValidator()!);

        RuleFor(c => c.Banco)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(b => (b ?? string.Empty).Length <= 2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2))
            .Must(b => CommonValidations.BancoInValidate(b ?? string.Empty)).WithMessage(MessageValidateConst.InvalidBanco);

        RuleFor(c => c.Sucursal)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(s => s!.Length <= 4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));

        RuleFor(c => c.Moneda)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(m => m!.Length <= 3).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 3));

        RuleFor(c => c.Referencia)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(r => r!.Length <= 12).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 12));

        RuleFor(c => c.Monto)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .Must(ma => MontoRegex().IsMatch(ma.ToString()!)) // Llama al método parcial
            .WithMessage(string.Format(MessageValidateConst.CantIntegersDecimals, 13, 2));

        RuleFor(c => c.CodigoProducto)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(cp => cp!.Length <= 4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));

        RuleFor(c => c.Oficina)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(o => o!.Length <= 4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));
    }

    [GeneratedRegex(@"^\d{1,13}(\.\d{0,2})?$")]
    private static partial Regex MontoRegex(); // Método parcial sin implementación
}