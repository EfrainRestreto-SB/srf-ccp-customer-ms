using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using Domain.Models.CreateCustomer.In;
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
        RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("FirstName is required.")
                .MaximumLength(40).WithMessage("FirstName must be at most 40 characters.");

        RuleFor(x => x.SecondName)
            .MaximumLength(40).WithMessage("SecondName must be at most 40 characters.");

        RuleFor(x => x.FirstLastName)
            .NotEmpty().WithMessage("FirstLastName is required.")
            .MaximumLength(40).WithMessage("FirstLastName must be at most 40 characters.");

        RuleFor(x => x.SecondLastName)
            .MaximumLength(40).WithMessage("SecondLastName must be at most 40 characters.");

        RuleFor(x => x.LegalName)
            .NotEmpty().WithMessage("LegalName is required.")
            .MaximumLength(160).WithMessage("LegalName must be at most 160 characters.");

        RuleFor(x => x.Gender)
            .NotEmpty().WithMessage("Gender is required.")
            .MaximumLength(1).WithMessage("Gender must be 1 character.")
            .Must(x => x == "F" || x == "M").WithMessage("Gender must be 'F' or 'M'.");

        RuleFor(x => x.ClientType)
            .NotEmpty().WithMessage("ClientType is required.")
            .MaximumLength(1).WithMessage("ClientType must be 1 character.")
            .Must(x => new[] { "R", "M", "G" }.Contains(x)).WithMessage("ClientType must be R, M, or G.");

        RuleFor(x => x.MaritalStatus)
            .NotEmpty().WithMessage("MaritalStatus is required.")
            .MaximumLength(1).WithMessage("MaritalStatus must be 1 character.")
            .Must(x => new[] { "1", "2", "3", "4", "5" }.Contains(x)).WithMessage("Invalid MaritalStatus.");

        RuleFor(x => x.Language)
            .NotEmpty().WithMessage("Language is required.")
            .MaximumLength(1).WithMessage("Language must be 1 character.");

        RuleFor(x => x.ConsultationLevel)
            .InclusiveBetween(0, 9).WithMessage("ConsultationLevel must be between 0 and 9.");

        RuleFor(x => x.RiskLevelCode)
            .NotEmpty().WithMessage("RiskLevelCode is required.")
            .MaximumLength(4).WithMessage("RiskLevelCode must be at most 4 characters.");

        RuleFor(x => x.EconomicSector)
            .NotEmpty().WithMessage("EconomicSector is required.")
            .MaximumLength(4).WithMessage("EconomicSector must be at most 4 characters.");

        RuleFor(x => x.EconomicActivity)
            .NotEmpty().WithMessage("EconomicActivity is required.")
            .MaximumLength(4).WithMessage("EconomicActivity must be at most 4 characters.");

        RuleFor(x => x.Stratum)
            .NotEmpty().WithMessage("Stratum is required.")
            .MaximumLength(1).WithMessage("Stratum must be 1 character.")
            .Must(x => new[] { "1", "2", "3", "4", "5", "6" }.Contains(x)).WithMessage("Invalid Stratum.");

        RuleFor(x => x.EducationLevel)
            .NotEmpty().WithMessage("EducationLevel is required.")
            .MaximumLength(4).WithMessage("EducationLevel must be at most 4 characters.");

        RuleFor(x => x.NichoCode)
            .MaximumLength(1).WithMessage("NichoCode must be 1 character.");

        RuleFor(x => x.IsPEP)
            .NotEmpty().WithMessage("IsPEP is required.")
            .MaximumLength(1).WithMessage("IsPEP must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("IsPEP must be 'Y' or 'N'.");

        RuleFor(x => x.ManagesPublicMoney)
            .NotEmpty().WithMessage("ManagesPublicMoney is required.")
            .MaximumLength(1).WithMessage("ManagesPublicMoney must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("ManagesPublicMoney must be 'Y' or 'N'.");

        RuleFor(x => x.HasPublicRecognition)
            .NotEmpty().WithMessage("HasPublicRecognition is required.")
            .MaximumLength(1).WithMessage("HasPublicRecognition must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("HasPublicRecognition must be 'Y' or 'N'.");

        RuleFor(x => x.Status)
            .NotEmpty().WithMessage("Status is required.")
            .MaximumLength(1).WithMessage("Status must be 1 character.");

        RuleFor(x => x.HasTaxExemptions)
            .NotEmpty().WithMessage("HasTaxExemptions is required.")
            .MaximumLength(1).WithMessage("HasTaxExemptions must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("HasTaxExemptions must be 'Y' or 'N'.");

        RuleFor(x => x.IsTaxWithHolder)
            .NotEmpty().WithMessage("IsTaxWithHolder is required.")
            .MaximumLength(1).WithMessage("IsTaxWithHolder must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("IsTaxWithHolder must be 'Y' or 'N'.");

        RuleFor(x => x.IsBigTaxpayer)
            .NotEmpty().WithMessage("IsBigTaxpayer is required.")
            .MaximumLength(1).WithMessage("IsBigTaxpayer must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("IsBigTaxpayer must be 'Y' or 'N'.");

        RuleFor(x => x.TaxpayerType)
            .NotEmpty().WithMessage("TaxpayerType is required.")
            .MaximumLength(1).WithMessage("TaxpayerType must be 1 character.")
            .Must(x => x == "R" || x == "N").WithMessage("TaxpayerType must be 'R' or 'N'.");

        RuleFor(x => x.SpecialTaxConditions)
            .NotEmpty().WithMessage("SpecialTaxConditions is required.")
            .MaximumLength(1).WithMessage("SpecialTaxConditions must be 1 character.")
            .Must(x => x == "Y" || x == "N").WithMessage("SpecialTaxConditions must be 'Y' or 'N'.");
    }
}
