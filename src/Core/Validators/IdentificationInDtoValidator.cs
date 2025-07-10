using FluentValidation;
using Domain.Dto.In;
using Domain.Dtos.Customer.In;

namespace Validators.Customer
{
    public class IdentificationInDtoValidator : AbstractValidator<IdentificationInDto>
    {
        public IdentificationInDtoValidator()
        {
            RuleFor(x => x.DocumentType).NotEmpty();
            RuleFor(x => x.ExpeditionDate).NotEmpty();
            RuleFor(x => x.IdentificationCountry).NotEmpty();
        }
    }
}