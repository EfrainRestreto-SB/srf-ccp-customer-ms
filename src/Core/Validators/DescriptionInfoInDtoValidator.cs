using FluentValidation;
using Domain.Dto.In;

namespace Validators.Customer
{
    public class DescriptionInfoInDtoValidator : AbstractValidator<DescriptionInfoInDto>
    {
        public DescriptionInfoInDtoValidator()
        {
            RuleFor(x => x.OfficeDescription).NotEmpty();
            RuleFor(x => x.GenderDescription).NotEmpty();
            RuleFor(static x => x.CountryDescription).NotEmpty();
            RuleFor(x => x.DocumentTypeDescription).NotEmpty();
            RuleFor(x => x.BirthCityDescription).NotEmpty();
            RuleFor(static x => x.EconomicActivityDescription).NotEmpty();
            RuleFor(x => x.InterviewResultDescription).NotEmpty();
        }
    }
}