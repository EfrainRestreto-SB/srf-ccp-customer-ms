using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.CreateCustomer.In;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Core.Validators.Customer;

public class ContactInfoInValidator : AbstractValidator<ContactInfoInModel>
{
    public ContactInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        RuleFor(x => x.EmailType)
                 .NotEmpty().WithMessage("Email type is required.")
                 .MaximumLength(2).WithMessage("Email type must be at most 2 characters.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .MaximumLength(50).WithMessage("Email must be at most 50 characters.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(x => x.PhoneType)
            .NotEmpty().WithMessage("Phone type is required.")
            .MaximumLength(2).WithMessage("Phone type must be at most 2 characters.");

        RuleFor(x => x.MainPhone)
            .NotEmpty().WithMessage("Main phone is required.")
            .MaximumLength(15).WithMessage("Main phone must be at most 15 digits.")
            .Matches(@"^\d+$").WithMessage("Main phone must contain only digits.");

        RuleFor(x => x.PhoneExtension)
            .MaximumLength(6).WithMessage("Phone extension must be at most 6 digits.")
            .Matches(@"^\d*$").WithMessage("Phone extension must contain only digits.");
    }
}