using FluentValidation;
using Domain.Dto.In;

namespace Application.Validators
{
    public class CustomerCreateInDtoValidator : AbstractValidator<CustomerCreateInDto>
    {
        public CustomerCreateInDtoValidator()
        {
            RuleFor(x => x.BasicInformation)
                .NotNull()
                .WithMessage("La información básica no puede ser nula.");

            RuleFor(x => x.ContactInformation)
                .NotNull()
                .WithMessage("La información de contacto no puede ser nula.");

            RuleFor(x => x.Addresses)
                .NotEmpty()
                .WithMessage("Debe haber al menos una dirección.");

            RuleFor(x => x.Descriptions)
                .NotEmpty()
                .WithMessage("Debe haber al menos una descripción.");

            RuleFor(x => x.References)
                .NotEmpty()
                .WithMessage("Debe haber al menos una referencia.");
        }
    }
}
