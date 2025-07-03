using Domain.Dtos.CreateCustomer.In;
using FluentValidation;

namespace Application.Validators.Customer
{
    public class BasicInformationInDtoValidator : AbstractValidator<BasicInformationInDto>
    {
        public BasicInformationInDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("FirstName is required.")
                .MaximumLength(50);

            RuleFor(x => x.SecondName)
                .MaximumLength(50);

            RuleFor(x => x.FirstLastName)
                .NotEmpty().WithMessage("FirstLastName is required.")
                .MaximumLength(50);

            RuleFor(x => x.SecondLastName)
                .MaximumLength(50);

            RuleFor(x => x.LegalName)
                .NotEmpty().WithMessage("LegalName is required.")
                .MaximumLength(100);

            RuleFor(x => x.Gender)
                .NotEmpty().WithMessage("Gender is required.")
                .MaximumLength(1);

            RuleFor(x => x.ClientType)
                .NotEmpty().WithMessage("ClientType is required.");

            RuleFor(x => x.MaritalStatus)
                .MaximumLength(20);

            RuleFor(x => x.Language)
                .MaximumLength(10);

            RuleFor(x => x.ConsultationLevel)
                .MaximumLength(20);

            RuleFor(x => x.RiskLevelCode)
                .MaximumLength(10);

            RuleFor(x => x.EconomicSector)
                .MaximumLength(50);

            RuleFor(x => x.EconomicActivity)
                .MaximumLength(50);

            RuleFor(x => x.EducationLevel)
                .MaximumLength(50);

            RuleFor(x => x.NicheCode)
                .MaximumLength(10);

            RuleFor(x => x.IsPEP)
                .NotEmpty().WithMessage("IsPEP is required.");

            RuleFor(x => x.ManagesPublicMoney)
                .NotEmpty().WithMessage("ManagesPublicMoney is required.");

            RuleFor(x => x.HasPublicReception)
                .NotEmpty().WithMessage("HasPublicReception is required.");

            RuleFor(x => x.Status)
                .NotEmpty().WithMessage("Status is required.");

            RuleFor(x => x.HasTaxExemptions)
                .NotEmpty().WithMessage("HasTaxExemptions is required.");

            RuleFor(x => x.HasTaxWithholdHolder)
                .NotEmpty().WithMessage("HasTaxWithholdHolder is required.");

            RuleFor(x => x.IsBigTaxpayer)
                .NotEmpty().WithMessage("IsBigTaxpayer is required.");

            RuleFor(x => x.TaxpayerType)
                .MaximumLength(30);

            RuleFor(x => x.SpecialTaxConditions)
                .MaximumLength(50);
        }
    }
}
