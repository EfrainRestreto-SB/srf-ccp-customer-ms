using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class BirthInfoInDtoValidator : AbstractValidator<BirthInfoInModel>
{
    public BirthInfoInDtoValidator()
    {
        RuleFor(x => x.Country)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.DateOfBirth)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
