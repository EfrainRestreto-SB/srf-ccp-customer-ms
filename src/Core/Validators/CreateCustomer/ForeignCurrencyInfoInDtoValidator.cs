using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ForeignCurrencyInfoInDtoValidator : AbstractValidator<ForeignCurrencyInfoInModel>
{
    public ForeignCurrencyInfoInDtoValidator()
    {
        RuleFor(x => x.CurrencyType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}