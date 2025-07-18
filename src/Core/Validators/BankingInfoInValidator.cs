using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class BankingInfoInValidator : AbstractValidator<BankingInfoIn>
{
    public BankingInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Affiliation Date Validation
        RuleFor(x => x.affiliationMonth)
            .InclusiveBetween(1, 12).WithMessage("Month must be between 1-12")
            .When(x => x.affiliationMonth.HasValue);

        RuleFor(x => x.affiliationDay)
            .InclusiveBetween(1, 31).WithMessage("Day must be between 1-31")
            .Must((model, day) => IsValidDayForMonth(model.affiliationMonth, day))
            .WithMessage("Invalid day for the specified month")
            .When(x => x.affiliationDay.HasValue && x.affiliationMonth.HasValue);

        RuleFor(x => x.affiliationYear)
            .InclusiveBetween(1900, DateTime.Now.Year)
            .WithMessage($"Year must be between 1900 and {DateTime.Now.Year}")
            .When(x => x.affiliationYear.HasValue);

        // Banking Codes
        RuleFor(x => x.affiliationOfficeCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(10).WithMessage("Office code must be 10 characters or less");

        RuleFor(x => x.affiliationChannel)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage("Channel code must be 2 characters or less");

        // Service Flags
        RuleFor(x => x.statementDelivery)
            .MaximumLength(1).WithMessage("Statement delivery flag must be 1 character or less");

        RuleFor(x => x.electronicOperations)
            .MaximumLength(1).WithMessage("Electronic operations flag must be 1 character or less");

        // Officer Information
        RuleFor(x => x.commercialOfficerCode)
            .MaximumLength(10).WithMessage("Officer code must be 10 characters or less");

        RuleFor(x => x.secondaryOfficerCode)
            .MaximumLength(10).WithMessage("Secondary officer code must be 10 characters or less");

        // Entity Information
        RuleFor(x => x.entityToAffiliateCode)
            .MaximumLength(10).WithMessage("Entity code must be 10 characters or less");

        RuleFor(x => x.superEntityType)
            .MaximumLength(2).WithMessage("Super entity type must be 2 characters or less");

        RuleFor(x => x.legalNature)
            .MaximumLength(2).WithMessage("Legal nature code must be 2 characters or less");

        RuleFor(x => x.businessType)
            .MaximumLength(2).WithMessage("Business type must be 2 characters or less");

        RuleFor(x => x.segmentCode)
            .MaximumLength(3).WithMessage("Segment code must be 3 characters or less");

        // Additional Banking Info
        RuleFor(x => x.interviewType)
            .MaximumLength(1).WithMessage("Interview type must be 1 character or less");

        RuleFor(x => x.bankRelation)
            .MaximumLength(1).WithMessage("Bank relation must be 1 character or less");

        RuleFor(x => x.serviceType)
            .MaximumLength(2).WithMessage("Service type must be 2 characters or less");

        RuleFor(x => x.riskPercentage)
            .InclusiveBetween(0, 100).WithMessage("Risk percentage must be between 0-100")
            .ScalePrecision(2, 5).WithMessage("Risk percentage must have max 2 decimal places")
            .When(x => x.riskPercentage.HasValue);
    }

    private bool IsValidDayForMonth(int? month, int? day)
    {
        if (!month.HasValue || !day.HasValue) return true;

        return month switch
        {
            2 => day <= 29, // Leap year check would require year
            4 or 6 or 9 or 11 => day <= 30,
            _ => day <= 31
        };
    }
}