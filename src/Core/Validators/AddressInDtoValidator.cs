using FluentValidation;
using Utils.Validators;

namespace Core.Validators
{
    public class AddressOutDtoValidator : AbstractValidator<AddressInDto>
    {
        public AddressOutDtoValidator()
        {
            RuleFor(x => x.City)
                .Required("City");

            RuleFor(x => x.Street)
                .Required("Street")
                .LengthBetween(5, 100, "Street");

            RuleFor(x => x.ZipCode)
                .OptionalMaxLength(10, "ZipCode");
        }
    }

    public class AddressInDto
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}
