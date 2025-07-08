using FluentValidation;

namespace Core.Validators
{
    public class EmploymentInfoOutDtoValidator : AbstractValidator<EmploymentInfoInDto>
    {
        public EmploymentInfoOutDtoValidator()
        {
            RuleFor(x => x.EmploymentStatus)
                .NotEmpty().WithMessage("EmploymentStatus is required.");

            RuleFor(x => x.Occupation)
                .NotEmpty().WithMessage("Occupation is required.");

            RuleFor(x => x.JobPosition)
                .NotEmpty().WithMessage("JobPosition is required.");

            RuleFor(x => x.EmploymentSector)
                .NotEmpty().WithMessage("EmploymentSector is required.");

            RuleFor(x => x.CompanyName)
                .NotEmpty().WithMessage("CompanyName is required.");

            RuleFor(x => x.CompanyNit)
                .NotEmpty().WithMessage("CompanyNit is required.");

            RuleFor(x => x.CompanyPhone)
                .NotEmpty().WithMessage("CompanyPhone is required.");

            RuleFor(x => x.CompanyCountry)
                .NotEmpty().WithMessage("CompanyCountry is required.");

            RuleFor(x => x.CompanyDepartment)
                .NotEmpty().WithMessage("CompanyDepartment is required.");

            RuleFor(x => x.CompanyCity)
                .NotEmpty().WithMessage("CompanyCity is required.");

            RuleFor(x => x.CompanyAddress)
                .NotEmpty().WithMessage("CompanyAddress is required.");

         

            RuleFor(x => x.IndependentIncome)
                .NotEmpty().WithMessage("IndependentIncome is required.");
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }

    public class EmploymentInfoInDto
    {
        internal object EmploymentStatus;
        internal object Occupation;
        internal object JobPosition;
        internal object IndependentIncome;
        internal object EmploymentSector;
        internal object CompanyName;
        internal object CompanyNit;
        internal object CompanyPhone;
        internal object CompanyCountry;
        internal object CompanyDepartment;
        internal object CompanyCity;
        internal object CompanyAddress;
        internal object CompanyEmail;
    }
}
