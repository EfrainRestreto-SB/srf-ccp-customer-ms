using FluentValidation;
using Domain.Dto.In;

namespace Validators.Customer
{
    public class IdentificationInDtoValidator : AbstractValidator<IdentificationDto>
    {
        public IdentificationInDtoValidator()
        {
            RuleFor(x => x.DocumentType).NotEmpty();
            RuleFor(x => x.ExpeditionDate).NotEmpty();
            RuleFor(x => x.IdentificationCountry).NotEmpty();
        }
    }
}