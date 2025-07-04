using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class InterviewInfoInDtoValidator : AbstractValidator<InterviewInfoInModel>
{
    public InterviewInfoInDtoValidator()
    {
        RuleFor(x => x.InterviewerName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(45).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.Interviewerid)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(25).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.InterviewerIdType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.InterviewerIdCountry)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.InterviewerCountry)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(MessageValidateConst.MaxLengthMessage);

        Rulefoor(x => x.InterviewerMonth)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.InterviewerDay)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.InterviewerYear) 
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.CustommerKnowledgeReport)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(300).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.InterviewerResult)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(300).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.InterviewerClientCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(9).WithMessage(MessageValidateConst.MaxLengthMessage);



    }
}
