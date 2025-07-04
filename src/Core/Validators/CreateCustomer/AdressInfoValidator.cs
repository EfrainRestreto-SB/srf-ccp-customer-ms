using Application.DTOs.Customer;
using FluentValidation;
using Application.Validators.Common;

namespace Application.Validators.Customer;

public class AddressInfoInDtoValidator : AbstractValidator<AddressInfoInDto>
{
    public AddressInfoInDtoValidator()
    {
        RuleFor(x => x.adreessLine1)
         .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
          .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(45).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.adresssLine2)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(45).withMessage(MessageValidateConst.MaxLengthMessage);


        RuleFor(x => x.adresssLine3)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(40).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.City)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(4).withMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x=> x.cityCode)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(4).withMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x=>x.country)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(35).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.postalCode)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(15).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x .residenceCountry)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(4).withMessage(MessageValidateConst.MaxLengthMessage);


        RuleFor(x=> x .CurrentRecidenceYears)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(2).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor (x => x .currentRecidenceMonths)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(2).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor (x=> x .housingType)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(1).withMessage(MessageValidateConst.MaxLengthMessage);

    }
}
