using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.CreateCustomer.In;
using FluentValidation;
using System;

namespace Core.Validators.Customer;

public class InterviewInfoInValidator : AbstractValidator<InterviewInfoInModel>
{
    public InterviewInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.InterviewerName)
             .NotEmpty().WithMessage("InterviewerName is required.")
             .MaximumLength(45).WithMessage("InterviewerName max length is 45.");

        RuleFor(x => x.InterviewerId)
            .NotEmpty().WithMessage("InterviewerId is required.")
            .MaximumLength(25).WithMessage("InterviewerId max length is 25.");

        RuleFor(x => x.InterviewerIdType)
            .NotEmpty().WithMessage("InterviewerIdType is required.")
            .MaximumLength(4).WithMessage("InterviewerIdType max length is 4.");

        RuleFor(x => x.InterviewerIdCountry)
            .NotEmpty().WithMessage("InterviewerIdCountry is required.")
            .MaximumLength(4).WithMessage("InterviewerIdCountry max length is 4.");

        RuleFor(x => x.InterviewMonth)
            .InclusiveBetween(1, 12).WithMessage("InterviewMonth must be between 1 and 12.");

        RuleFor(x => x.InterviewDay)
            .InclusiveBetween(1, 31).WithMessage("InterviewDay must be between 1 and 31.");

        RuleFor(x => x.InterviewYear)
            .InclusiveBetween(1900, 2100).WithMessage("InterviewYear must be a valid year.");

        RuleFor(x => x.CustomerKnowledgeReport)
            .NotEmpty().WithMessage("CustomerKnowledgeReport is required.")
            .MaximumLength(300).WithMessage("CustomerKnowledgeReport max length is 300.");

        RuleFor(x => x.InterviewResult)
            .NotEmpty().WithMessage("InterviewResult is required.")
            .MaximumLength(300).WithMessage("InterviewResult max length is 300.");

        RuleFor(x => x.MasterClientCode)
            .GreaterThan(0).WithMessage("MasterClientCode must be greater than 0.");
    }
}