using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.CreateCustomer.In;
using FluentValidation;
using System;

namespace Core.Validators.Customer;

public class EmploymentInfoInValidator : AbstractValidator<EmploymentInfoInModel>
{
    public EmploymentInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.CompanyName)
                .NotEmpty().WithMessage("CompanyName is required.")
                .MaximumLength(45);

        RuleFor(x => x.CompanyAddress)
            .NotEmpty().WithMessage("CompanyAddress is required.")
            .MaximumLength(45);

        RuleFor(x => x.JobPosition)
            .NotEmpty().WithMessage("JobPosition is required.")
            .MaximumLength(45);

        RuleFor(x => x.PreviousCompany)
            .NotEmpty().WithMessage("PreviousCompany is required.")
            .MaximumLength(45);

        RuleFor(x => x.EmploymentStartDay)
            .InclusiveBetween(1, 31).WithMessage("EmploymentStartDay must be between 1 and 31.");

        RuleFor(x => x.EmploymentStartMonth)
            .InclusiveBetween(1, 12).WithMessage("EmploymentStartMonth must be between 1 and 12.");

        RuleFor(x => x.EmploymentStartYear)
            .InclusiveBetween(1900, 2100).WithMessage("EmploymentStartYear must be valid.");

        RuleFor(x => x.CompanyCityCode)
            .NotEmpty().WithMessage("CompanyCityCode is required.")
            .MaximumLength(4);

        RuleFor(x => x.CompanyCountry)
            .NotEmpty().WithMessage("CompanyCountry is required.")
            .MaximumLength(4);

        RuleFor(x => x.ContractType)
            .NotEmpty().WithMessage("ContractType is required.")
            .MaximumLength(4);

        RuleFor(x => x.DepartmentCode)
            .NotEmpty().WithMessage("DepartmentCode is required.")
            .MaximumLength(4);

        RuleFor(x => x.WorkPhone)
            .NotEmpty().WithMessage("WorkPhone is required.")
            .Matches(@"^\d{1,15}$").WithMessage("WorkPhone must be numeric and max 15 digits.");

        RuleFor(x => x.WorkExtension)
            .MaximumLength(10);

        RuleFor(x => x.PreviousJobYears)
            .InclusiveBetween(0, 99);

        RuleFor(x => x.PreviousJobMonths)
            .InclusiveBetween(0, 11);

        RuleFor(x => x.EmployeesCount)
            .InclusiveBetween(0, 99999);

        RuleFor(x => x.OccupationCode)
            .NotEmpty().WithMessage("OccupationCode is required.")
            .MaximumLength(4);

        RuleFor(x => x.DependentsCount)
            .InclusiveBetween(0, 99);
    }
}
