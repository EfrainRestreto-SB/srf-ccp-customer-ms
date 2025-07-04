using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class BankingInfoInDtoValidator : AbstractValidator<BankingInfoInModel>
{
    public BankingInfoInDtoValidator()
    {
        RuleFor(x => x.affiliationMonth)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.affiliationDay)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.affiliationYear)
              .NotNull().WithMessage(MessageValidateConst.NullMessage)
              .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
              .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.affiliationOfficeCode)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x => x.affiliantionChannel)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x => x.statementDelivery)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x => x.electronicOperations)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(8).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor( x=> x.commercialOfficerCode)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.secondaryOfficerCode)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.entityToAffiliateCode)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(X => X.superEntityType)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.legalNature)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.businnessType)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.segmentCode)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.superEntityCode)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.addressTypeCode)
             .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.undergraduateDegree)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.interviewType)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.bankRelation)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.serviceType)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.riskPercentece)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .GreaterThan(6).WithMessage(MessageValidateConst.GreaterThanZeroMessage);

    }
}
