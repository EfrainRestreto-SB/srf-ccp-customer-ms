using FluentValidation;
using Domain.Dto.In;

namespace Validators.Customer
{
    public class ForeignCurrencyAccountInDtoValidator : AbstractValidator<ForeignCurrencyAccountInDtoValidator>
    {
        private object AccountType;
        private object AccountNumber;
        private object InstitutionName;
        private object InstitutionCountry;
        private object ForeignCurrencyCode;
        private object FormOfPayment;
        private object CurrencyValue;
        private object FormReceiptCountry;
        private object FormPaymentCountry;
        private object FormOfReceipt;

        public ForeignCurrencyAccountInDtoValidator()
        {
            RuleFor(x => x.AccountType).NotEmpty();
            RuleFor(x => x.AccountNumber).NotEmpty();
            RuleFor(x => x.InstitutionName).NotEmpty();
            RuleFor(static x => x.InstitutionCountry).NotEmpty();
            RuleFor(x => x.ForeignCurrencyCode).NotEmpty();
            RuleFor(x => x.CurrencyValue).NotEmpty();
            RuleFor(x => x.FormOfPayment).NotEmpty();
            RuleFor(x => x.FormOfReceipt).NotEmpty();
            RuleFor(x => x.FormPaymentCountry).NotEmpty();
            RuleFor(x => x.FormReceiptCountry).NotEmpty();
        }
    }
}