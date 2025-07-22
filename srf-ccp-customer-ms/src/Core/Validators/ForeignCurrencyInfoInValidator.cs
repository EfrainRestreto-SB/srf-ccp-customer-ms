using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class ForeignCurrencyInfoInValidator : AbstractValidator<ForeignCurrencyInfoInModel>
{
    public ForeignCurrencyInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.ForeignTransactions)
            .NotEmpty().WithMessage("ForeignTransactions is required.")
            .Length(1).WithMessage("ForeignTransactions must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("ForeignTransactions must be 'Y' or 'N'.");

        RuleFor(x => x.ForeignProducts)
            .NotEmpty().WithMessage("ForeignProducts is required.")
            .Length(1).WithMessage("ForeignProducts must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("ForeignProducts must be 'Y' or 'N'.");

        RuleFor(x => x.Transaction1Amount)
            .GreaterThanOrEqualTo(0).WithMessage("Transaction1Amount must be a positive number.");

        RuleFor(x => x.Transaction1Type)
            .MaximumLength(4).WithMessage("Transaction1Type max length is 4.")
            .NotEmpty();

        RuleFor(x => x.Transaction2Amount)
            .GreaterThanOrEqualTo(0).WithMessage("Transaction2Amount must be a positive number.");

        RuleFor(x => x.Transaction2Type)
            .MaximumLength(4).WithMessage("Transaction2Type max length is 4.")
            .NotEmpty();

        RuleFor(x => x.Transaction3Amount)
            .GreaterThanOrEqualTo(0).WithMessage("Transaction3Amount must be a positive number.");

        RuleFor(x => x.Transaction3Type)
            .MaximumLength(4).WithMessage("Transaction3Type max length is 4.")
            .NotEmpty();

        RuleFor(x => x.ForeignBank1Name)
            .MaximumLength(20).WithMessage("ForeignBank1Name max length is 20.");

        RuleFor(x => x.ForeignBank1Product)
            .MaximumLength(20).WithMessage("ForeignBank1Product max length is 20.");

        RuleFor(x => x.ForeignBank1Currency)
            .MaximumLength(3).WithMessage("ForeignBank1Currency max length is 3.")
            .NotEmpty();

        RuleFor(x => x.ForeignBank1Account)
            .MaximumLength(20).WithMessage("ForeignBank1Account max length is 20.");

        RuleFor(x => x.ForeignBank1Balance)
            .GreaterThanOrEqualTo(0).WithMessage("ForeignBank1Balance must be a positive number.");

        RuleFor(x => x.ForeignBank1Country)
            .MaximumLength(4).WithMessage("ForeignBank1Country max length is 4.")
            .NotEmpty();

        RuleFor(x => x.ForeignBank1City)
            .MaximumLength(20).WithMessage("ForeignBank1City max length is 20.");

        RuleFor(x => x.IsForexMarketIntermediary)
            .NotEmpty().WithMessage("IsForexMarketIntermediary is required.")
            .Length(1).WithMessage("IsForexMarketIntermediary must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("IsForexMarketIntermediary must be 'Y' or 'N'.");
    }
}