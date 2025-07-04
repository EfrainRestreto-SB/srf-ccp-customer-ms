using Domain.Constants;
using Domain.Models.CreateCustomer.In;
using FluentValidation;

namespace Core.Validators.CreateCustomer;

public class BasicInformationInDtoValidator : AbstractValidator<BasicInformationInModel>
{
    public BasicInformationInDtoValidator()
    {
        RuleFor(x => x.FirstName)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
        .maxLength(40).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.SecondName)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(40).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.fisrtLastName)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(40).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.secondLastName)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(40).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x =>x.LegalName)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(160).withMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x=> x.gender)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(1).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.clientType)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(1).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.maritalStatus)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(1).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.lenguage)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(1).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x .consultationLevel)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(1).withMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x=> x .RiskLevelCode )
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(4).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x=> x.economicSector)
        .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(4).withMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x=> x.econmicActivity)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(4).withMessage(MessageValidateConst.MaxLengthMessage);
          
        RuleFor(x => x.stratum)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(3).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.educationLevel)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(4).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.nichoCode)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .maxLength(1).withMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x =>x.isPec)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.managesPublicMoney)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);


            Rulefor (x  => x.haspublicRecognition)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)   
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor (x => x.status)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        RuleFor(x => x.hasTaxExemptions)
        .notNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);   

        RuleFor (x => x.isTaxwithHolder)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

       rulefor (x => x.isBiTaWithHolder)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);


        RuleFor(x => x.taxpayerType)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);

        Rulefor(x=> x.specialTaxCondition)
            .NotNull().WithMessage(MessageValidateConst.EmptyMessage)
            .NotEmpty().WithMessage(MessageValidateConst.EmptyMessage)
            .MaximumLength(1).WithMessage(MessageValidateConst.MaxLengthMessage);
    }


}

