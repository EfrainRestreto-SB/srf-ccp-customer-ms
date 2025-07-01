using Domain.Constants;
using Domain.Models.CreateCdt.In;
using FluentValidation;

namespace Core.Validators.CreateCdt;

public class ConceptoInValidator : AbstractValidator<ConceptoInModel>
{
    public ConceptoInValidator()
    {
        Rules();
    }

    private void Rules() 
    {
        RuleFor(c => c.Codigo)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(c => CommonValidations.CodigoConceptoInValidate(c!)).WithMessage(MessageValidateConst.InvalidCodigoConcepto);

        RuleFor(c => c.Descripcion)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(of => of!.Length <= 45).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 45));
    }
}
