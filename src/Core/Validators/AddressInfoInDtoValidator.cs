using FluentValidation;
using Domain.Dto.In;
using Domain.Dtos.Customer.In;

namespace Validators.Customer
{
    public class AddressInfoInDtoValidator : AbstractValidator<AddressInfoInDto>
    {
        public AddressInfoInDtoValidator()
        {
            RuleFor(x => x.AddressLine1).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.Department).NotEmpty();
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.PostalCode).NotEmpty();
        }
    }
}