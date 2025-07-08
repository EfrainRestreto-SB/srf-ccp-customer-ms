using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class InterviewInfoOutDtoValidator : AbstractValidator<InterviewInfoInDto>
    {
        public InterviewInfoOutDtoValidator()
        {
            RuleFor(x => x.InterviewDate)
                .NotEmpty().WithMessage("InterviewDate is required.");

            RuleFor(x => x.InterviewTime)
                .NotEmpty().WithMessage("InterviewTime is required.");

            RuleFor(x => x.InterviewModality)
                .NotEmpty().WithMessage("InterviewModality is required.");

            RuleFor(x => x.InterviewType)
                .NotEmpty().WithMessage("InterviewType is required.");

            RuleFor(x => x.InterviewCity)
                .NotEmpty().WithMessage("InterviewCity is required.");

            RuleFor(x => x.InterviewDepartment)
                .NotEmpty().WithMessage("InterviewDepartment is required.");

            RuleFor(x => x.InterviewCountry)
                .NotEmpty().WithMessage("InterviewCountry is required.");

            RuleFor(x => x.InterviewPlace)
                .NotEmpty().WithMessage("InterviewPlace is required.");

            RuleFor(x => x.InterviewerName)
                .NotEmpty().WithMessage("InterviewerName is required.");

            RuleFor(x => x.InterviewerPosition)
                .NotEmpty().WithMessage("InterviewerPosition is required.");

            RuleFor(x => x.InterviewResult)
                .NotEmpty().WithMessage("InterviewResult is required.");

            RuleFor(x => x.InterviewResultCode)
                .NotEmpty().WithMessage("InterviewResultCode is required.");
        }
    }
}
