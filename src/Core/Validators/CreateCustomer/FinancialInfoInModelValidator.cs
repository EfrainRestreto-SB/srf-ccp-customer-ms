using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class FinancialInfoInDtoValidator : AbstractValidator<FinancialInfoInModel>
{
    public FinancialInfoInDtoValidator()
    {
        RuleFor(x => x.Income)
            .GreaterThan(0).WithMessage(MessageValidateConst.MustBeGreaterThanZero);

        RuleFor(x => x.Expenses)
            .GreaterThanOrEqualTo(0).WithMessage(MessageValidateConst.MustBeNonNegative);
    }
}
