using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class DescriptionsInDtoValidator : AbstractValidator<DescriptionsInModel>
{
    public DescriptionsInDtoValidator()
    {
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
