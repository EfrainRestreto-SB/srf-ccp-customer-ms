using FluentValidation;
using Domain.Dto.In;

namespace Validators.Customer
{
    public class BirthInfoInDtoValidator : AbstractValidator<BirthInfoInDto>
    {
        public BirthInfoInDtoValidator()
        {
            RuleFor(x => x.BirthCountry).NotEmpty();
            RuleFor(x => x.BirthDepartment).NotEmpty();
            RuleFor(x => x.BirthCity).NotEmpty();
        }
    }
}