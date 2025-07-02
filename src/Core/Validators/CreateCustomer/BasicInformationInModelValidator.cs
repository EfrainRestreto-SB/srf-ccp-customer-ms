using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class BasicInformationInDtoValidator : AbstractValidator<BasicInformationInModel>
{
    public BasicInformationInDtoValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.Gender)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.ClientType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
