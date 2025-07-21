using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;
using System;

namespace Core.Validators.Customer;

public class BirthInfoInValidator : AbstractValidator<BirthInfoInModel>
{
    private object MessageValidateConst;

    public BirthInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.BirthMonth)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .InclusiveBetween(1, 12).WithMessage(MessageValidateConst.InvalidMonth);

        RuleFor(x => x.BirthDay)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .InclusiveBetween(1, 31).WithMessage(MessageValidateConst.InvalidDay)
            .Must((model, day) => IsValidDay(model.BirthYear, model.BirthMonth, day))
            .WithMessage(MessageValidateConst.InvalidDateCombination);

        RuleFor(x => x.BirthYear)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .InclusiveBetween(1900, DateTime.Now.Year)
            .WithMessage(string.Format(MessageValidateConst.YearBetween, 1900, DateTime.Now.Year));

        // Birth Place Validation
        RuleFor(x => x.BirthCountry)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(3).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 3));

        RuleFor(x => x.BirthDepartment)
            .MaximumLength(50).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 50));

        RuleFor(x => x.BirthCity)
            .MaximumLength(50).WithMessage(string.Format(MessageValidateConst.StringLessThanOrEqualTo, 50));
    }

    private bool IsValidDay(int? year, int? month, int day)
    {
        if (!year.HasValue || !month.HasValue) return true;

        try
        {
            var daysInMonth = DateTime.DaysInMonth(year.Value, month.Value);
            return day <= daysInMonth;
        }
        catch
        {
            return false;
        }
    }
}