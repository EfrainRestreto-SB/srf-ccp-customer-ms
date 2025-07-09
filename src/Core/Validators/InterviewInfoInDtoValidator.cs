using FluentValidation;
using Domain.Dto.In;

namespace Validators.Customer
{
    public class InterviewInfoInDtoValidator : AbstractValidator<InterviewInfoInDto>
    {
        public InterviewInfoInDtoValidator()
        {
            RuleFor(static x => x.FullNameInterviewer).NotEmpty();
            RuleFor(x => x.FullIdInterviewer).NotEmpty();
            RuleFor(x => x.InterviewDate).NotEmpty();
            RuleFor(x => x.InterviewPlace).NotEmpty();
            RuleFor(x => x.InterviewCountry).NotEmpty();
            RuleFor(x => x.InterviewDepartment).NotEmpty();
            RuleFor(x => x.InterviewCity).NotEmpty();
            RuleFor(x => x.InterviewResultCode).NotEmpty();
        }
    }
}