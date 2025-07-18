using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;
using System;

namespace Core.Validators.Customer;

public class EmploymentInfoInValidator : AbstractValidator<EmploymentInfoIn>
{
    public EmploymentInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Company Information
        RuleFor(x => x.companyName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(100).WithMessage("Company name must be 100 characters or less");

        RuleFor(x => x.companyAddress)
            .MaximumLength(200).WithMessage("Company address must be 200 characters or less")
            .When(x => !string.IsNullOrEmpty(x.companyAddress));

        // Employment Details
        RuleFor(x => x.jobPosition)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(50).WithMessage("Job position must be 50 characters or less");

        RuleFor(x => x.previousCompany)
            .MaximumLength(100).WithMessage("Previous company must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.previousCompany));

        // Employment Date Validation
        RuleFor(x => x.employmentStartMonth)
            .InclusiveBetween(1, 12).WithMessage("Month must be between 1-12")
            .When(x => x.employmentStartMonth.HasValue);

        RuleFor(x => x.employmentStartDay)
            .InclusiveBetween(1, 31).WithMessage("Day must be between 1-31")
            .Must((model, day) => IsValidDayForMonth(model.employmentStartMonth, day))
            .WithMessage("Invalid day for the specified month")
            .When(x => x.employmentStartDay.HasValue && x.employmentStartMonth.HasValue);

        RuleFor(x => x.employmentStartYear)
            .InclusiveBetween(1900, DateTime.Now.Year)
            .WithMessage($"Year must be between 1900 and {DateTime.Now.Year}")
            .When(x => x.employmentStartYear.HasValue);

        // Location Information
        RuleFor(x => x.companyCityCode)
            .MaximumLength(10).WithMessage("City code must be 10 characters or less");

        RuleFor(x => x.companyCountry)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(3).WithMessage("Country code must be 3 characters or less");

        // Contract and Department
        RuleFor(x => x.contractType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage("Contract type must be 2 characters or less");

        RuleFor(x => x.departmentCode)
            .MaximumLength(10).WithMessage("Department code must be 10 characters or less");

        // Contact Information
        RuleFor(x => x.workPhone)
            .MaximumLength(15).WithMessage("Work phone must be 15 characters or less")
            .Matches(@"^[0-9\+\-\(\)\s]*$").WithMessage("Work phone contains invalid characters")
            .When(x => !string.IsNullOrEmpty(x.workPhone));

        RuleFor(x => x.workExtension)
            .MaximumLength(10).WithMessage("Extension must be 10 characters or less")
            .Matches(@"^[0-9]*$").WithMessage("Extension must contain only numbers")
            .When(x => !string.IsNullOrEmpty(x.workExtension));

        // Experience and Stats
        RuleFor(x => x.previousJobYears)
            .InclusiveBetween(0, 80).WithMessage("Previous job years must be between 0-80")
            .When(x => x.previousJobYears.HasValue);

        RuleFor(x => x.previousJobMonths)
            .InclusiveBetween(0, 11).WithMessage("Previous job months must be between 0-11")
            .When(x => x.previousJobMonths.HasValue);

        RuleFor(x => x.employeesCount)
            .InclusiveBetween(1, 100000).WithMessage("Employees count must be between 1-100000")
            .When(x => x.employeesCount.HasValue);

        RuleFor(x => x.occupationCode)
            .MaximumLength(10).WithMessage("Occupation code must be 10 characters or less");

        RuleFor(x => x.dependentsCount)
            .InclusiveBetween(0, 50).WithMessage("Dependents count must be between 0-50")
            .When(x => x.dependentsCount.HasValue);
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