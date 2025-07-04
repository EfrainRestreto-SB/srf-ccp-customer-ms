using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ForeignCurrencyInfoInDtoValidator : AbstractValidator<ForeignCurrencyInfoInModel>
{
    public ForeignCurrencyInfoInDtoValidator()
    {
        RuleFor(x => x.foreingTransactions)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxlength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.foreignProducts)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.transaction1Amount)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .GreaterThan(15).WithMessage(MessageValidateConst.GreaterThanZeroMessage);

        RuleFor(x => x.transaction1Type)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(15).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.transaction1Amount)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .GreaterThan(4).WithMessage(MessageValidateConst.GreaterThanZeroMessage);

        RuleFor(x => x.transaction2Type)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(15).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.transaction2Amount)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .GreaterThan(4).WithMessage(MessageValidateConst.GreaterThanZeroMessage);

        RuleFor(x => x.transaction3Type)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x => x.foreingBanck1Name)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.foreingBanck1Prodcut)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.foreingBanck1Currency)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(3).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.foreingBanck1Account)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.foreingBanck1Balance)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .GreaterThan(1).WithMessage(MessageValidateConst.GreaterThanZeroMessage);

        RuleFor(x => x.foreingBanck1Country)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.foreingBanckCity)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.isForexMaketIntermediary)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);
    }
}