using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ReferencesInDtoValidator : AbstractValidator<ReferencesInModel>
{
    public ReferencesInDtoValidator()
    {
        RuleFor(x => x.PersonName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.Relationship)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
