using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class ReferencesInDtoValidator : AbstractValidator<ReferencesInModel>
{
    public ReferencesInDtoValidator()
    {
        RuleFor(x => x.referenceType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
             .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.companyName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
             .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 60));

        RuleFor(x => x.contactName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(80).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 80));

        RuleFor(x => x.firstLastName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(80).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 80));

        RuleFor(x => x.secondLastName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(80).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 80));

        RuleFor(x => x.countryCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(35).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 35));

        RuleFor(x => x.departmentCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => xcityCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.landlinePhone)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(15).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 15));

        RuleFor(x => x.phoneExtencion)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(15).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 15));

        RuleFor(x => x.relationship)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));
    }
}
