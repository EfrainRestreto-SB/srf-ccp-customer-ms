using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators
{
    public class IdentificationOutDtoValidator : AbstractValidator<IdentificationInDto>
    {
        public IdentificationOutDtoValidator()
        {
            RuleFor(x => x.IdType).NotEmpty().WithMessage("IdType is required.");
            RuleFor(x => x.IdNumber).NotEmpty().WithMessage("IdNumber is required.");
            RuleFor(x => x.IssueDate).NotEmpty().WithMessage("IssueDate is required.");
            RuleFor(x => x.IssueCountry).NotEmpty().WithMessage("IssueCountry is required.");
            RuleFor(x => x.IssueDepartment).NotEmpty().WithMessage("IssueDepartment is required.");
            RuleFor(x => x.IssueCity).NotEmpty().WithMessage("IssueCity is required.");
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}

