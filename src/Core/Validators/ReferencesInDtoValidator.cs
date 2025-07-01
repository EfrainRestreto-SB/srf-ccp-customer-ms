using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ReferencesInDtoValidator : AbstractValidator<ReferencesInModel>
{
    public ReferencesInDtoValidator()
    {
        RuleFor(x => x.ReferenceName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
