using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class FinancialInfoInValidator : AbstractValidator<FinancialInfoInModel>
{
    public FinancialInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.MonthlyIncome)
           .GreaterThanOrEqualTo(0).WithMessage("MonthlyIncome must be a positive number.");

        RuleFor(x => x.OtherIncome)
            .GreaterThanOrEqualTo(0).WithMessage("OtherIncome must be a positive number.");

        RuleFor(x => x.FamilyExpenses)
            .GreaterThanOrEqualTo(0).WithMessage("FamilyExpenses must be a positive number.");

        RuleFor(x => x.TotalLiabilities)
            .GreaterThanOrEqualTo(0).WithMessage("TotalLiabilities must be a positive number.");

        RuleFor(x => x.OtherAssets)
            .GreaterThanOrEqualTo(0).WithMessage("OtherAssets must be a positive number.");

        RuleFor(x => x.RealStateAssets)
            .GreaterThanOrEqualTo(0).WithMessage("RealStateAssets must be a positive number.");

        RuleFor(x => x.TotalAssets)
            .GreaterThanOrEqualTo(0).WithMessage("TotalAssets must be a positive number.");

        RuleFor(x => x.TotalIncome)
            .GreaterThanOrEqualTo(0).WithMessage("TotalIncome must be a positive number.");

        RuleFor(x => x.TotalExpenses)
            .GreaterThanOrEqualTo(0).WithMessage("TotalExpenses must be a positive number.");

        RuleFor(x => x.FundsOriginDescription1)
            .MaximumLength(60).WithMessage("FundsOriginDescription1 max length is 60.");

        RuleFor(x => x.FundsOriginDescription2)
            .MaximumLength(60).WithMessage("FundsOriginDescription2 max length is 60.");

        RuleFor(x => x.FundsOriginDescription3)
            .MaximumLength(60).WithMessage("FundsOriginDescription3 max length is 60.");
    }
}