using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class FinancialInfoInValidator : AbstractValidator<FinancialInfoIn>
{
    public FinancialInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Monetary Amount Validations
        RuleFor(x => x.monthlyIncome)
            .GreaterThanOrEqualTo(0).WithMessage("Monthly income cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Monthly income must have max 2 decimal places and 18 total digits");

        RuleFor(x => x.otherIncome)
            .GreaterThanOrEqualTo(0).WithMessage("Other income cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Other income must have max 2 decimal places and 18 total digits")
            .When(x => x.otherIncome.HasValue);

        RuleFor(x => x.familyExpenses)
            .GreaterThanOrEqualTo(0).WithMessage("Family expenses cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Family expenses must have max 2 decimal places and 18 total digits");

        RuleFor(x => x.totalLiabilities)
            .GreaterThanOrEqualTo(0).WithMessage("Total liabilities cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Total liabilities must have max 2 decimal places and 18 total digits")
            .When(x => x.totalLiabilities.HasValue);

        // Assets Validation
        RuleFor(x => x.realStateAssets)
            .GreaterThanOrEqualTo(0).WithMessage("Real state assets cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Real state assets must have max 2 decimal places and 18 total digits")
            .When(x => x.realStateAssets.HasValue);

        RuleFor(x => x.otherAssets)
            .GreaterThanOrEqualTo(0).WithMessage("Other assets cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Other assets must have max 2 decimal places and 18 total digits")
            .When(x => x.otherAssets.HasValue);

        // Totals Validation
        RuleFor(x => x.totalAssets)
            .GreaterThanOrEqualTo(0).WithMessage("Total assets cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Total assets must have max 2 decimal places and 18 total digits");

        RuleFor(x => x.totalIncome)
            .GreaterThanOrEqualTo(0).WithMessage("Total income cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Total income must have max 2 decimal places and 18 total digits");

        RuleFor(x => x.totalExpenses)
            .GreaterThanOrEqualTo(0).WithMessage("Total expenses cannot be negative")
            .ScalePrecision(2, 18).WithMessage("Total expenses must have max 2 decimal places and 18 total digits");

        // Funds Origin Descriptions
        RuleFor(x => x.fundsOriginDescription1)
            .MaximumLength(200).WithMessage("Funds origin description 1 must be 200 characters or less")
            .When(x => !string.IsNullOrEmpty(x.fundsOriginDescription1));

        RuleFor(x => x.fundsOriginDescription2)
            .MaximumLength(200).WithMessage("Funds origin description 2 must be 200 characters or less")
            .When(x => !string.IsNullOrEmpty(x.fundsOriginDescription2));

        RuleFor(x => x.fundsOriginDescription3)
            .MaximumLength(200).WithMessage("Funds origin description 3 must be 200 characters or less")
            .When(x => !string.IsNullOrEmpty(x.fundsOriginDescription3));

        // Cross-field Validation
        RuleFor(x => x.totalIncome)
            .Must((model, totalIncome) =>
                (model.monthlyIncome + (model.otherIncome ?? 0)) <= (totalIncome * 1.05m) &&
                (model.monthlyIncome + (model.otherIncome ?? 0)) >= (totalIncome * 0.95m))
            .WithMessage("Total income should be approximately equal to monthly + other income")
            .When(x => x.totalIncome > 0 && x.monthlyIncome > 0);
    }
}