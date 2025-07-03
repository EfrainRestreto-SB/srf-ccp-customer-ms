using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

public class ReferencesInDtoValidator : AbstractValidator<ReferencesInModel>
{
    public ReferencesInDtoValidator()
    {
        RuleFor(c => c.ReferenceName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(100).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 100));

        RuleFor(c => c.ReferencePhone)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Matches(@"^\d{7,15}$").WithMessage("El teléfono debe tener entre 7 y 15 dígitos numéricos.");

        RuleFor(x => x.ReferenceRelationship)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(50).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 50));
    }
}
