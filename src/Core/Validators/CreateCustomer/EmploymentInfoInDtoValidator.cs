using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class EmploymentInfoInDtoValidator : AbstractValidator<EmploymentInfoInModel>
{
    public EmploymentInfoInDtoValidator()
    {
        RuleFor(x => x.CompanyName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);

        RuleFor(x => x.Position)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}