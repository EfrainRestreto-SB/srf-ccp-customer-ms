using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class ReferenceInValidator : AbstractValidator<ReferenceInModel>
{
    private object MessageValidateConst;

    public ReferenceInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Reference Type Validation
        RuleFor(x => x.ReferenceType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage("Reference Type Must Be 2 Characters Or Less");

        // Company Information
        RuleFor(x => x.CompanyName)
            .MaximumLength(100).WithMessage("Company Name Must Be 100 Characters Or Less")
            .When(x => !string.IsNullOrEmpty(x.CompanyName));

        // Contact Person Validation
        RuleFor(x => x.ContactName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage("Contact Name Must Be 60 Characters Or Less");

        RuleFor(x => x.FirstLastName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(60).WithMessage("Last Name Must Be 60 Characters Or Less");

        RuleFor(x => x.SecondLastName)
            .MaximumLength(60).WithMessage("Second Last Name Must Be 60 Characters Or Less")
            .When(x => !string.IsNullOrEmpty(x.SecondLastName));

        // Location Information
        RuleFor(x => x.CountryCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(3).WithMessage("Country Code Must Be 3 Characters Or Less");

        RuleFor(x => x.DepartmentCode)
            .MaximumLength(10).WithMessage("Department Code Must Be 10 Characters Or Less")
            .When(x => !string.IsNullOrEmpty(x.DepartmentCode));

        RuleFor(x => x.CityCode)
            .MaximumLength(10).WithMessage("City Code Must Be 10 Characters Or Less")
            .When(x => !string.IsNullOrEmpty(x.CityCode));

        // Contact Information
        RuleFor(x => x.LandlinePhone)
            .MaximumLength(15).WithMessage("Landline Must Be 15 Characters Or Less")
            .Matches(@"^[0-9\+\-\(\)\s]*$").WithMessage("Landline Contains Invalid Characters")
            .When(x => !string.IsNullOrEmpty(x.LandlinePhone));

        RuleFor(x => x.MobilePhone)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(15).WithMessage("Mobile Must Be 15 Characters Or Less")
            .Matches(@"^[0-9\+\-\(\)\s]+$").WithMessage("Mobile Contains Invalid Characters");

        RuleFor(x => x.PhoneExtension)
            .MaximumLength(10).WithMessage("Extension Must Be 10 Characters Or Less")
            .Matches(@"^[0-9]*$").WithMessage("Extension Must Contain Only Numbers")
            .When(x => !string.IsNullOrEmpty(x.PhoneExtension));

        // Relationship
        RuleFor(x => x.Relationship)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage("Relationship Code Must Be 2 Characters Or Less");
    }
}
