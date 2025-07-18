using Domain.Constants;
using Domain.Models.Customer.In;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Core.Validators.Customer;

public class ContactInfoInValidator : AbstractValidator<ContactInfoIn>
{
    public ContactInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Email Validation
        RuleFor(x => x.emailType)
            .MaximumLength(2).WithMessage("Email type must be 2 characters or less");

        RuleFor(x => x.email)
            .MaximumLength(100).WithMessage("Email must be 100 characters or less")
            .When(x => !string.IsNullOrEmpty(x.email))
            .Matches(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")
            .WithMessage("Invalid email format")
            .When(x => !string.IsNullOrEmpty(x.email));

        // Phone Validation
        RuleFor(x => x.phoneType)
            .MaximumLength(2).WithMessage("Phone type must be 2 characters or less");

        RuleFor(x => x.mainPhone)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(15).WithMessage("Phone number must be 15 characters or less")
            .Matches(@"^[0-9\+\-\(\)\s]+$")
            .WithMessage("Phone number contains invalid characters");

        RuleFor(x => x.phoneExtension)
            .MaximumLength(10).WithMessage("Extension must be 10 characters or less")
            .When(x => !string.IsNullOrEmpty(x.phoneExtension))
            .Matches(@"^[0-9]+$")
            .WithMessage("Extension must contain only numbers")
            .When(x => !string.IsNullOrEmpty(x.phoneExtension));
    }
}