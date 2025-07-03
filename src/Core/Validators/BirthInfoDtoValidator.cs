using Domain.Dtos.CreateCustomer.In;
using Domain.Dtos.Out;
using FluentValidation;

namespace Application.Validators.Customer.In
{
    public class BirthInfoDtoValidator : AbstractValidator<BirthInfoDto>
    {
        public BirthInfoDtoValidator()
        {
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country is required.");
            RuleFor(x => x.State).NotEmpty().WithMessage("State is required.");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is required.");
            RuleFor(x => x.BirthDate)
                .NotEmpty().WithMessage("BirthDate is required.")
                .LessThan(DateTime.Today).WithMessage("BirthDate must be in the past.");
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
