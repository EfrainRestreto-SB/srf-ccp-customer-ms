using FluentValidation;

namespace Validators.Customer
{
    public class FinancialInfoInDtoValidator : AbstractValidator<FinancialInfoDto>
    {
        public FinancialInfoInDtoValidator()
        {
            RuleFor(x => x.OtherIncome)
                .NotNull().WithMessage("El campo OtherIncome no debe ser nulo.")
                .NotEmpty().WithMessage("El campo OtherIncome es obligatorio.");

            RuleFor(x => x.FamilyIncome)
                .NotNull().WithMessage("El campo FamilyIncome no debe ser nulo.")
                .NotEmpty().WithMessage("El campo FamilyIncome es obligatorio.");

            RuleFor(x => x.TotalIncome)
                .NotNull().WithMessage("El campo TotalIncome no debe ser nulo.")
                .NotEmpty().WithMessage("El campo TotalIncome es obligatorio.");

            RuleFor(x => x.AssetsValue)
                .NotNull().WithMessage("El campo AssetsValue no debe ser nulo.")
                .NotEmpty().WithMessage("El campo AssetsValue es obligatorio.");

            RuleFor(x => x.LiabilitiesValue)
                .NotNull().WithMessage("El campo LiabilitiesValue no debe ser nulo.")
                .NotEmpty().WithMessage("El campo LiabilitiesValue es obligatorio.");

            RuleFor(x => x.MonthlyIncome)
                .NotNull().WithMessage("El campo MonthlyIncome no debe ser nulo.")
                .NotEmpty().WithMessage("El campo MonthlyIncome es obligatorio.");

            RuleFor(x => x.MonthlyExpenses)
                .NotNull().WithMessage("El campo MonthlyExpenses no debe ser nulo.")
                .NotEmpty().WithMessage("El campo MonthlyExpenses es obligatorio.");

            RuleFor(x => x.FundOriginDescription)
                .NotNull().WithMessage("El campo FundOriginDescription no debe ser nulo.")
                .NotEmpty().WithMessage("El campo FundOriginDescription es obligatorio.");

            RuleFor(x => x.FundDestinationDescription)
                .NotNull().WithMessage("El campo FundDestinationDescription no debe ser nulo.")
                .NotEmpty().WithMessage("El campo FundDestinationDescription es obligatorio.");
        }
    }

    public class FinancialInfoDto
    {
        internal object OtherIncome;
        internal object FundDestinationDescription;
        internal object FundOriginDescription;
        internal object MonthlyExpenses;
        internal object MonthlyIncome;
        internal object LiabilitiesValue;
        internal object AssetsValue;
        internal object TotalIncome;
        internal object FamilyIncome;
    }
}
