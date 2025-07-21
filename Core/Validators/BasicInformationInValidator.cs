using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class BasicInformationInValidator : AbstractValidator<BasicInformationInModel>
{
    public BasicInformationInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Name Fields
        RuleFor(x => x.FirstName)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 60));

        RuleFor(x => x.SecondName)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 60));

        RuleFor(x => x.FirstLastName)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 60));

        RuleFor(x => x.SecondLastName)
            .MaximumLength(60).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 60));

        RuleFor(x => x.LegalName)
            .MaximumLength(100).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 100));

        // Demographic Fields
        RuleFor(x => x.Gender)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.MaritalStatus)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.Language)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        // Classification Fields
        RuleFor(x => x.ClientType)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        RuleFor(x => x.ConsultationLevel)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        // Economic Data
        RuleFor(x => x.EconomicSector)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));

        RuleFor(x => x.EconomicActivity)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));

        RuleFor(x => x.Stratum)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.EducationLevel)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        RuleFor(x => x.NichoCode)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 4));

        // Risk and Compliance
        RuleFor(x => x.RiskLevelCode)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        RuleFor(x => x.IsPEP)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.ManagesPublicMoney)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.HasPublicRecognition)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        // Tax Information
        RuleFor(x => x.HasTaxExemptions)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.IsTaxWithHolder)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.IsBigTaxpayer)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        RuleFor(x => x.TaxpayerType)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 2));

        RuleFor(x => x.SpecialTaxConditions)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));

        // Status
        RuleFor(x => x.Status)
            .MaximumLength(1).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 1));
    }
}