using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class FinancialInfoOutDtoValidator : AbstractValidator<FinancialInfoOutDto>
    {
        public FinancialInfoOutDtoValidator()
        {
            RuleFor(static x => x.OtherIncome)
                .NotEmpty().WithMessage("OtherIncome is required.");

            RuleFor(x => x.IncomeFrequency)
                .NotEmpty().WithMessage("IncomeFrequency is required.");

            RuleFor(x => x.FamilyExpenses)
                .NotEmpty().WithMessage("FamilyExpenses is required.");

            RuleFor(x => x.OtherAssets)
                .NotEmpty().WithMessage("OtherAssets is required.");

            RuleFor(x => x.OtherLiabilities)
                .NotEmpty().WithMessage("OtherLiabilities is required.");

            RuleFor(x => x.TotalIncome)
                .NotEmpty().WithMessage("TotalIncome is required.");

            RuleFor(x => x.TotalExpenses)
                .NotEmpty().WithMessage("TotalExpenses is required.");

            RuleFor(x => x.TotalAssets)
                .NotEmpty().WithMessage("TotalAssets is required.");

            RuleFor(x => x.TotalLiabilities)
                .NotEmpty().WithMessage("TotalLiabilities is required.");

            RuleFor(x => x.FundsOrigin)
                .NotEmpty().WithMessage("FundsOrigin is required.");

            RuleFor(x => x.FundsOriginDescription)
                .NotEmpty().WithMessage("FundsOriginDescription is required.");

            RuleFor(x => x.FundsDestination)
                .NotEmpty().WithMessage("FundsDestination is required.");

            RuleFor(x => x.FundsDestinationDescription)
                .NotEmpty().WithMessage("FundsDestinationDescription is required.");
        }
    }
}