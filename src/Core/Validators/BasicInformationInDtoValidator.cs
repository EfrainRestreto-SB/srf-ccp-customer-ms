using FluentValidation;
using Domain.Dto.In;
using Domain.Dtos.Customer.In;

namespace Validators.Customer
{
    public class BasicInformationInDtoValidator : AbstractValidator<BasicInformationInDto>
    {
        public BasicInformationInDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.FirstSurname).NotEmpty();
            RuleFor(x => x.Genders).NotEmpty();
            RuleFor(x => x.IdentityStatus).NotEmpty();
            RuleFor(x => x.InternalStatus).NotEmpty();
            RuleFor(x => x.Language).NotEmpty();
            RuleFor(x => x.EducationLevelCode).NotEmpty();
            RuleFor(x => x.EducationLevel).NotEmpty();
            RuleFor(x => x.EthnicCode).NotEmpty();
            RuleFor(x => x.Ethnic).NotEmpty();
            RuleFor(x => x.StatusPeps).NotEmpty();
        }
    }
}