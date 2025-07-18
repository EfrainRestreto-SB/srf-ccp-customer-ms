using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class BasicInformationInValidator : AbstractValidator<BasicInformationIn>
{
    public BasicInformationInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Name Fields
        RuleFor(x => x.firstName)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 60));

        RuleFor(x => x.secondName)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 60));

        RuleFor(x => x.firstLastName)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 60));

        RuleFor(x => x.secondLastName)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 60));

        RuleFor(x => x.legalName)
            .MaximumLength(100).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 100));

        // Demographic Fields
        RuleFor(x => x.gender)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.maritalStatus)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.language)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        // Classification Fields
        RuleFor(x => x.clientType)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        RuleFor(x => x.consultationLevel)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        // Economic Data
        RuleFor(x => x.economicSector)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));

        RuleFor(x => x.economicActivity)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));

        RuleFor(x => x.stratum)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.educationLevel)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        RuleFor(x => x.nichoCode)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));

        // Risk and Compliance
        RuleFor(x => x.riskLevelCode)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        RuleFor(x => x.isPEP)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.managesPublicMoney)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.hasPublicRecognition)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        // Tax Information
        RuleFor(x => x.hasTaxExemptions)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.isTaxWithHolder)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.isBigTaxpayer)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.taxpayerType)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        RuleFor(x => x.specialTaxConditions)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        // Status
        RuleFor(x => x.status)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));
    }
}