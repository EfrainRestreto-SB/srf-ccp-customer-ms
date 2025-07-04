using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class BirthInfoInDtoValidator : AbstractValidator<BirthInfoInModel>
{
    public BirthInfoInDtoValidator()
    {
        RuleFor(x => x.birthMonth)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(x => x?.maxlength <= 2).withMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));


        RuleFor(x => x.birthDay)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(x => x?.maxlength <= 2).withMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));

        RuleFor(x => x.birthYear)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(x => x?.maxlength <= 4).withMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.birthCountry)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(x => x?.maxlength <= 4).withMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.birthDepartament)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(x => x?.maxlength <= 4).withMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.birthCity)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .Must(x => x?.maxlength <= 4).withMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));
    }
}
