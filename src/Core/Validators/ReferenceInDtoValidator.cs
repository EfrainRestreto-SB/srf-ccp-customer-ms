using FluentValidation;
using Domain.Dto.In;

namespace Validators.Customer
{
    public class ReferenceInDtoValidator : AbstractValidator<ReferenceInDto>
    {
        public ReferenceInDtoValidator()
        {
            RuleFor(static x => x.PersonType).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(static x => x.CompanyName).NotEmpty();
            RuleFor(x => x.CountryCode).NotEmpty();
            RuleFor(x => x.CityCode).NotEmpty();
            RuleFor(x => x.MobilePhone).NotEmpty();
            RuleFor(x => x.PhoneDescription).NotEmpty();
        }
    }
}