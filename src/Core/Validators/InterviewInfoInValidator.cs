using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;
using System;

namespace Core.Validators.Customer;

public class InterviewInfoInValidator : AbstractValidator<InterviewInfoIn>
{
    public InterviewInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Interviewer Information
        RuleFor(x => x.interviewerName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(100).WithMessage("Interviewer name must be 100 characters or less");

        RuleFor(x => x.interviewerId)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(20).WithMessage("Interviewer ID must be 20 characters or less");

        RuleFor(x => x.interviewerIdType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage("ID type must be 2 characters or less");

        RuleFor(x => x.interviewerIdCountry)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(3).WithMessage("Country code must be 3 characters or less");

        // Interview Date Validation
        RuleFor(x => x.interviewMonth)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .InclusiveBetween(1, 12).WithMessage("Month must be between 1-12");

        RuleFor(x => x.interviewDay)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .InclusiveBetween(1, 31).WithMessage("Day must be between 1-31")
            .Must((model, day) => IsValidDayForMonth(model.interviewMonth, day))
            .WithMessage("Invalid day for the specified month");

        RuleFor(x => x.interviewYear)
            .NotNull().WithMessage(MessageValidateConst.NullMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .InclusiveBetween(2000, DateTime.Now.Year)
            .WithMessage($"Year must be between 2000 and {DateTime.Now.Year}");

        // Interview Results
        RuleFor(x => x.customerKnowledgeReport)
            .MaximumLength(1).WithMessage("Knowledge report code must be 1 character or less")
            .When(x => !string.IsNullOrEmpty(x.customerKnowledgeReport));

        RuleFor(x => x.interviewResult)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage("Result code must be 1 character or less");

        // Client Code
        RuleFor(x => x.masterClientCode)
            .MaximumLength(20).WithMessage("Master client code must be 20 characters or less")
            .When(x => !string.IsNullOrEmpty(x.masterClientCode));
    }

    private bool IsValidDayForMonth(int month, int day)
    {
        return month switch
        {
            2 => day <= 29, // Leap year check would require year
            4 or 6 or 9 or 11 => day <= 30,
            _ => day <= 31
        };
    }
}