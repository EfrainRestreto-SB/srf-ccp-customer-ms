using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class ForeignCurrencyInfoInValidator : AbstractValidator<ForeignCurrencyInfoIn>
{
    public ForeignCurrencyInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Foreign Transactions Overview
        RuleFor(x => x.foreignTransactions)
            .MaximumLength(1).WithMessage("Foreign transactions flag must be 1 character or less");

        RuleFor(x => x.foreignProducts)
            .MaximumLength(1).WithMessage("Foreign products flag must be 1 character or less");

        // Transaction Validations
        ValidateTransaction(x => x.transaction1Amount, x => x.transaction1Type, "1");
        ValidateTransaction(x => x.transaction2Amount, x => x.transaction2Type, "2");
        ValidateTransaction(x => x.transaction3Amount, x => x.transaction3Type, "3");

        // Foreign Bank Account 1
        RuleFor(x => x.foreignBank1Name)
            .MaximumLength(100).WithMessage("Bank name must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.foreignBank1Name));

        RuleFor(x => x.foreignBank1Product)
            .MaximumLength(50).WithMessage("Bank product must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.foreignBank1Product));

        RuleFor(x => x.foreignBank1Currency)
            .MaximumLength(3).WithMessage("Currency code must be 3 characters or less")
            .When(x => !string.IsNullOrEmpty(x.foreignBank1Currency));

        RuleFor(x => x.foreignBank1Account)
            .MaximumLength(50).WithMessage("Account number must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.foreignBank1Account));

        RuleFor(x => x.foreignBank1Balance)
            .ScalePrecision(2, 18).WithMessage("Balance must have max 2 decimal places and 18 total digits")
            .When(x => x.foreignBank1Balance.HasValue);

        RuleFor(x => x.foreignBank1Country)
            .MaximumLength(3).WithMessage("Country code must be 3 characters or less")
            .When(x => !string.IsNullOrEmpty(x.foreignBank1Country));

        RuleFor(x => x.foreignBank1City)
            .MaximumLength(50).WithMessage("City must be 50 characters or less")
            .When(x => !string.IsNullOrEmpty(x.foreignBank1City));

        // Forex Market
        RuleFor(x => x.isForexMarketIntermediary)
            .MaximumLength(1).WithMessage("Forex intermediary flag must be 1 character or less");
    }

    private void ValidateTransaction(
        System.Linq.Expressions.Expression<Func<ForeignCurrencyInfoIn, decimal?>> amountSelector,
        System.Linq.Expressions.Expression<Func<ForeignCurrencyInfoIn, string>> typeSelector,
        string transactionNumber)
    {
        RuleFor(amountSelector)
            .ScalePrecision(2, 18).WithMessage($"Transaction {transactionNumber} amount must have max 2 decimal places and 18 total digits")
            .When(x => amountSelector.Compile()(x).HasValue);

        RuleFor(typeSelector)
            .MaximumLength(3).WithMessage($"Transaction {transactionNumber} type must be 3 characters or less")
            .When(x => !string.IsNullOrEmpty(typeSelector.Compile()(x)));
    }
}