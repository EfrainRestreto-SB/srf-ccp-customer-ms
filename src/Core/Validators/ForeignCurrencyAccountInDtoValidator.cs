using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class ForeignCurrencyAccountOUtDtoValidator : AbstractValidator<ForeignCurrencyAccountOutDto>
    {
        public ForeignCurrencyAccountOUtDtoValidator()
        {
            RuleFor(x => x.AccountType)
                .NotEmpty().WithMessage("AccountType is required.");

            RuleFor(x => x.AccountInstitution)
                .NotEmpty().WithMessage("AccountInstitution is required.");

            RuleFor(x => x.AccountNumber)
                .NotEmpty().WithMessage("AccountNumber is required.");

            RuleFor(x => x.AccountCurrency)
                .NotEmpty().WithMessage("AccountCurrency is required.");

            RuleFor(x => x.AccountPurpose)
                .NotEmpty().WithMessage("AccountPurpose is required.");

            RuleFor(x => x.AccountCountry)
                .NotEmpty().WithMessage("AccountCountry is required.");

            RuleFor(x => x.AccountState)
                .NotEmpty().WithMessage("AccountState is required.");

            RuleFor(x => x.AccountCity)
                .NotEmpty().WithMessage("AccountCity is required.");

            RuleFor(x => x.AccountDepartment)
                .NotEmpty().WithMessage("AccountDepartment is required.");

            RuleFor(x => x.AccountAddress)
                .NotEmpty().WithMessage("AccountAddress is required.");

            RuleFor(x => x.AccountPhone)
                .NotEmpty().WithMessage("AccountPhone is required.");

            RuleFor(x => x.FirstAccountHolderName)
                .NotEmpty().WithMessage("FirstAccountHolderName is required.");
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
