using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class InterviewInfoInDtoValidator : AbstractValidator<InterviewInfoInModel>
{
    public InterviewInfoInDtoValidator()
    {
        RuleFor(x => x.InterviewerName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage);
    }
}
