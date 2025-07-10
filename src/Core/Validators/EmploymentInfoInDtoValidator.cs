using FluentValidation;
using Domain.Dto.In;
using static Domain.Dtos.Customer.In.CustomerCreateInDto;
using Domain.Dtos.Customer.In;

namespace Validators.Customer
{
    public class EmploymentInfoInDtoValidator : AbstractValidator<EmploymentInfoInDto>
    {
        public EmploymentInfoInDtoValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty();
            RuleFor(x => x.CompanyNit).NotEmpty();
            RuleFor(static x => x.JobAddress).NotEmpty();
            RuleFor(x => x.Phone).NotEmpty();
            RuleFor(x => x.EmploymentStatus).NotEmpty();
            RuleFor(x => x.EmploymentStartDay).NotEmpty();
            RuleFor(x => x.EmploymentContractType).NotEmpty();
            RuleFor(static x => x.EmploymentType).NotEmpty();
            RuleFor(x => x.JobTitle).NotEmpty();
            RuleFor(x => x.EconomicSector).NotEmpty();
            RuleFor(x => x.EconomicActivity).NotEmpty();
        }
    }
}