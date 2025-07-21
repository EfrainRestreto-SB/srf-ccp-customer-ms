using AutoMapper;
using Domain.Dto.In;
using Domain.Dto.Out;
using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;
using Domain.Models.Customer;
using Domain.Models.Customer.In;
using Domain.Models.Customer.Out;

namespace Application.Mappers;

public class CustomerMappingsProfile : Profile
{
    public CustomerMappingsProfile() => CreateMapping();

    private void CreateMapping()
    {
        // IN
        CreateMap<CreateCustomerInDto, CreateCustomerInModel>();
        CreateMap<BasicInformationInDto, BasicInformationInModel>();
        CreateMap<IdentificationInDto, IdentificationInModel>();
        CreateMap<BirthInfoInDto, BirthInfoInModel>();
        CreateMap<ContactInfoInDto, ContactInfoInModel>();
        CreateMap<AddressInfoInDto, AddressInfoInModel>();
        CreateMap<FinancialInfoInDto, FinancialInfoModel>();
        CreateMap<EmploymentInfoInDto, EmploymentInfoInModel>();
        CreateMap<ForeignCurrencyInfoInDto, ForeignCurrencyAccountInModel>();
        CreateMap<BankingInfoInDto, bankingInfoInModel>();
        CreateMap<InterviewInfoInDto, InterviewInfoInModel>();
        CreateMap<ReferenceInDto, ReferenceInModel>();
        CreateMap<DescriptionsInDto, DescriptionInfoInModel>();

        // OUT
        CreateMap<CreateCustomerOutDto, CreateCustomerOutModel>();
        CreateMap<BasicInformationOutDto, BasicInformationOutModel>();
        CreateMap<IdentificationOutDto, IdentificationOutModel>();
        CreateMap<BirthInfoOutDto, BirthInfoOutModel>();
        CreateMap<ContactInfoOutDto, ContactInfoOutModel>();
        CreateMap<AddressInfoOutDto, AddressInfoOutModel>();
        CreateMap<FinancialInfoOutDto, FinancialfoOutModel>();
        CreateMap<EmploymentInfoOutDto, EmploymenInfoOutModel>();
        CreateMap<ForeignCurrencyInfoOutDto, ForeignCurrencyAccountOutModel>();
        CreateMap<BankingInfoOutDto, BankingInfoOutModel>();
        CreateMap<InterviewInfoOutDto, InterviewInfoOutModel>();
        CreateMap<ReferenceOutDto, ReferenceOutModel>();
        CreateMap<DescriptionInfoOutDto, DescriptionOutfoModel>();
    }

    private void CreateMap<T1, T2>()
    {
        throw new NotImplementedException();
    }
}
