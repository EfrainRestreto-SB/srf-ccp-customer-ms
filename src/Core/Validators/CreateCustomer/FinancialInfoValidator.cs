using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class FinancialInfoInDtoValidator : AbstractValidator<FinancialInfoInModel>
{
    public FinancialInfoInDtoValidator()
    {
        RuleFor(x => x.montlyIncome)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));

        RuleFor(x => x.otherIncome)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));

        RuleFor(x=> x.familyExpence)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));

          RuleFor(x => x.totalLiabilities)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));

        RuleFor(x => x.otherAssets)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));

        RuleFor(x => x.realStatesAsssets)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));

        RuleFor(x=> x.totalAssets)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));


        RuleFor(x => x.totalIncome)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));

        RuleFor(x => x.totalExpences)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,20));

        RuleFor(x => x .foudsOriginDescription1)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,60));  

        RuleFor (x=> x.foudsOriginDescription2)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,60));

        RuleFor(x => x.foudsOriginDescription3)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage,60));



    }
}
