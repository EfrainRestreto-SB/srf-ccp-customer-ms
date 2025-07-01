using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class FinancialInfoInDtoValidator : AbstractValidator<FinancialInfoInModel>
{
    public FinancialInfoInDtoValidator()
    {
        RuleFor(x => x.AnnualIncome)
            .GreaterThan(0).WithMessage(MessageValidateConst.InvalidNumber);
    }
}
