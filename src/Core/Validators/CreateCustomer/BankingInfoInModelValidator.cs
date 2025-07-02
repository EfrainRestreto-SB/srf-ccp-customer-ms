using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class BankingInfoInDtoValidator : AbstractValidator<BankingInfoInModel>
{
    public BankingInfoInDtoValidator()
    {
        RuleFor(x => x.BankName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
