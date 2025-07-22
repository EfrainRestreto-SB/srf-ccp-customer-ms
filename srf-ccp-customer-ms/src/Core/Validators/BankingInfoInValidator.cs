using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class BankingInfoInValidator : AbstractValidator<BankingInfoInModel>
{
    public BankingInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.AffiliationMonth)
           .InclusiveBetween(1, 12).WithMessage("AffiliationMonth must be between 1 and 12.");

        RuleFor(x => x.AffiliationDay)
            .InclusiveBetween(1, 31).WithMessage("AffiliationDay must be between 1 and 31.");

        RuleFor(x => x.AffiliationYear)
            .InclusiveBetween(1900, 2100).WithMessage("AffiliationYear must be a valid 4-digit year.");

        RuleFor(x => x.AffiliationOfficeCode)
            .NotEmpty().WithMessage("AffiliationOfficeCode is required.")
            .MaximumLength(4).WithMessage("AffiliationOfficeCode must be at most 4 characters.");

        RuleFor(x => x.AffiliationChannel)
            .NotEmpty().WithMessage("AffiliationChannel is required.")
            .MaximumLength(4).WithMessage("AffiliationChannel must be at most 4 characters.");

        RuleFor(x => x.StatementDelivery)
            .NotEmpty().WithMessage("StatementDelivery is required.")
            .Length(1).WithMessage("StatementDelivery must be exactly 1 character.")
            .Must(x => x == "R" || x == "O" || x == "C")
            .WithMessage("StatementDelivery must be one of: R, O, C.");

        RuleFor(x => x.ElectronicOperations)
            .MaximumLength(8).WithMessage("ElectronicOperations must be at most 8 characters.");

        RuleFor(x => x.CommercialOfficerCode)
            .MaximumLength(4).WithMessage("CommercialOfficerCode must be at most 4 characters.");

        RuleFor(x => x.SecondaryOfficerCode)
            .MaximumLength(4).WithMessage("SecondaryOfficerCode must be at most 4 characters.");

        RuleFor(x => x.EntityToAffiliateCode)
            .MaximumLength(4).WithMessage("EntityToAffiliateCode must be at most 4 characters.");

        RuleFor(x => x.SuperEntityType)
            .MaximumLength(4).WithMessage("SuperEntityType must be at most 4 characters.");

        RuleFor(x => x.LegalNature)
            .MaximumLength(4).WithMessage("LegalNature must be at most 4 characters.");

        RuleFor(x => x.BusinessType)
            .MaximumLength(4).WithMessage("BusinessType must be at most 4 characters.");

        RuleFor(x => x.SegmentCode)
            .MaximumLength(4).WithMessage("SegmentCode must be at most 4 characters.");

        RuleFor(x => x.SuperEntityCode)
            .MaximumLength(4).WithMessage("SuperEntityCode must be at most 4 characters.");

        RuleFor(x => x.AddressTypeCode)
            .MaximumLength(4).WithMessage("AddressTypeCode must be at most 4 characters.");

        RuleFor(x => x.UndergraduateDegree)
            .MaximumLength(4).WithMessage("UndergraduateDegree must be at most 4 characters.");

        RuleFor(x => x.InterviewType)
            .Length(1).WithMessage("InterviewType must be exactly 1 character.");

        RuleFor(x => x.BankRelation)
            .Length(1).WithMessage("BankRelation must be exactly 1 character.");

        RuleFor(x => x.ServiceType)
            .MaximumLength(4).WithMessage("ServiceType must be at most 4 characters.");

        RuleFor(x => x.RiskPercentage)
            .InclusiveBetween(0, 100).WithMessage("RiskPercentage must be between 0 and 100.");
    }
}
