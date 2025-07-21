using Domain.Constants;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using FluentValidation;

namespace Core.Validators.Customer;

public class BankingInfoInValidator : AbstractValidator<BankingInfoInModel>
{
    public BankingInfoInValidator()
    {
        Rules();
    }

    private void Rules()
    {
        // Affiliation Date Validation
        RuleFor(x => x.AffiliationMonth)
            .InclusiveBetween(1, 12).WithMessage("El mes debe estar entre 1 y 12")
            .When(x => x.AffiliationMonth.HasValue);

        RuleFor(x => x.AffiliationDay)
            .InclusiveBetween(1, 31).WithMessage("El día debe estar entre 1 y 31")
            .Must((model, day) => IsValidDayForMonth(model.AffiliationMonth, day))
            .WithMessage("El día no es válido para el mes especificado")
            .When(x => x.AffiliationDay.HasValue && x.AffiliationMonth.HasValue);

        RuleFor(x => x.AffiliationYear)
            .InclusiveBetween(1900, DateTime.Now.Year)
            .WithMessage($"El año debe estar entre 1900 y {DateTime.Now.Year}")
            .When(x => x.AffiliationYear.HasValue);

        // Banking Codes
        RuleFor(x => x.AffiliationOfficeCode)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(10).WithMessage("El código de oficina debe tener máximo 10 caracteres");

        RuleFor(x => x.AffiliationChannel)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(2).WithMessage("El canal de afiliación debe tener máximo 2 caracteres");

        // Service Flags
        RuleFor(x => x.StatementDelivery)
            .MaximumLength(1).WithMessage("La bandera de envío de extracto debe tener máximo 1 carácter");

        RuleFor(x => x.ElectronicOperations)
            .MaximumLength(1).WithMessage("La bandera de operaciones electrónicas debe tener máximo 1 carácter");

        // Officer Information
        RuleFor(x => x.CommercialOfficerCode)
            .MaximumLength(10).WithMessage("El código del oficial comercial debe tener máximo 10 caracteres");

        RuleFor(x => x.SecondaryOfficerCode)
            .MaximumLength(10).WithMessage("El código del oficial secundario debe tener máximo 10 caracteres");

        // Entity Information
        RuleFor(x => x.EntityToAffiliateCode)
            .MaximumLength(10).WithMessage("El código de la entidad a afiliar debe tener máximo 10 caracteres");

        RuleFor(x => x.SuperEntityType)
            .MaximumLength(2).WithMessage("El tipo de súper entidad debe tener máximo 2 caracteres");

        RuleFor(x => x.LegalNature)
            .MaximumLength(2).WithMessage("La naturaleza jurídica debe tener máximo 2 caracteres");

        RuleFor(x => x.BusinessType)
            .MaximumLength(2).WithMessage("El tipo de negocio debe tener máximo 2 caracteres");

        RuleFor(x => x.SegmentCode)
            .MaximumLength(3).WithMessage("El código de segmento debe tener máximo 3 caracteres");

        // Additional Banking Info
        RuleFor(x => x.InterviewType)
            .MaximumLength(1).WithMessage("El tipo de entrevista debe tener máximo 1 carácter");

        RuleFor(x => x.BankRelation)
            .MaximumLength(1).WithMessage("La relación bancaria debe tener máximo 1 carácter");

        RuleFor(x => x.ServiceType)
            .MaximumLength(2).WithMessage("El tipo de servicio debe tener máximo 2 caracteres");

        RuleFor(x => x.RiskPercentage)
            .InclusiveBetween(0, 100).WithMessage("El porcentaje de riesgo debe estar entre 0 y 100")
            .When(x => x.RiskPercentage.HasValue);
    }

    private bool IsValidDayForMonth(int? month, int? day)
    {
        if (!month.HasValue || !day.HasValue) return true;

        return month switch
        {
            2 => day <= 29, // No se valida año bisiesto aquí
            4 or 6 or 9 or 11 => day <= 30,
            _ => day <= 31
        };
    }
}
