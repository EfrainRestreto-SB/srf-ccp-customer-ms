using Domain.Dto.In;
using FluentValidation;

namespace Core.Validators.In
{
    public class CustomerCreateOutDtoValidator : AbstractValidator<CustomerCreateOutDto>
    {
        public CustomerCreateOutDtoValidator()
        {
            RuleFor(x => x.BasicInformation)
                .NotNull()
                .SetValidator(new BasicInformationOutDtoValidator());

            RuleFor(x => x.ContactInfo)
                .NotNull()
                .SetValidator(new ContactInfoOutDtoValidator());

            RuleFor(x => x.AddressInfo)
                .NotNull()
                .SetValidator(new AddressInfoOutDtoValidator());

            RuleFor(x => x.DescriptionInfo)
                .NotNull()
                .SetValidator(new DescriptionInfoOutDtoValidator());

            RuleForEach(x => x.References)
                .SetValidator(new ReferenceOutDtoValidator());
        }
    }

    internal class ReferenceOutDtoValidator : AbstractValidator<ReferenceOutDto>
    {
        public ReferenceOutDtoValidator()
        {
            // Add validation rules here
        }
    }

    internal class DescriptionInfoOutDtoValidator : AbstractValidator<DescriptionInfoOutDto>
    {
        public DescriptionInfoOutDtoValidator()
        {
            // Add validation rules here
        }
    }

    internal class AddressInfoOutDtoValidator : AbstractValidator<AddressInfoOutDto>
    {
        public AddressInfoOutDtoValidator()
        {
            // Add validation rules here
        }
    }

    internal class BasicInformationOutDtoValidator : AbstractValidator<BasicInformationOutDto>
    {
        public BasicInformationOutDtoValidator()
        {
            // Add validation rules here
        }
    }

    internal class ContactInfoOutDtoValidator : AbstractValidator<ContactInfoOutDto>
    {
        public ContactInfoOutDtoValidator()
        {
            // Add validation rules here
        }
    }
}
