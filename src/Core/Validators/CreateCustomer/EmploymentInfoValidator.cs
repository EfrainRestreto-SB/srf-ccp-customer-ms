using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class EmploymentInfoInDtoValidator : AbstractValidator<EmploymentInfoInModel>
{
    public EmploymentInfoInDtoValidator()
    {
        RuleFor(x => x.comapanyName)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(45).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 45));

        RuleFor(x => x.comanyAdress)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(45).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 45));

        RuleFor(x => x.jobPosition)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(45).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 45));

        RuleFor(x => x.previousCompany)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(45).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 45));

        RuleFor(x => x.employmentStartMonth)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));

        RuleFor(x => x.employmentStartDay)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));

        RuleFor(x => x.employmentStartYear)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor (x => x.companyCityCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor (x => x.companyCountry)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));
        Rulefor (x => x .contractType)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor(x => x.departamentCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

       Rulefor(x => x.companyCountry)
         .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
         .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
         .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        Rulefor(x=> x.contracType)
          .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
         .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
         .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor (x => x.departamentCode)
         .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
         .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
         .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        Rulefor (x=> x.workphone)
         .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
         .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
         .MaximumLength(15).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 15));

        RuleFor(x=> x.workExtension)
          .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
         .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
         .MaximumLength(10).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 10));

        RuleFor(x  => x.previousJobYears)
          .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
         .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
         .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));

        RuleFor(x=> x.previousJobMonths)
          .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
         .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
         .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));

        RuleFor (x => x.employeesCount)
          .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
          .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
          .MaximumLength(5).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 5));

        RuleFor (x => x.occuppationCode)
          .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
          .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
          .MaximumLength(4).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 4));

        RuleFor (x =>x.dependentsCount)
          .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
          .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
          .MaximumLength(2).WithMessage(string.Format(MessageValidateConst.MaxLengthMessage, 2));






    }
}
