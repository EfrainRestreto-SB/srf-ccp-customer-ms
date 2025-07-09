using AutoMapper;
using Domain.Dto.Out;
using BasicInformationOutDto = Application.Mappers.BasicInformationOutDto;
using IdentificationOutDto = Application.Mappers.IdentificationOutDto;

namespace Application.Mappings
{
    public class CustomerMappingsProfile : Profile
    {
        public CustomerMappingsProfile()
        {
            CreateMap<CustomerInModel, CustomerCreateOutDto>();
            CreateMap<BasicInformationInModel, BasicInformationOutDto>();
            CreateMap<IdentificationInModel, IdentificationOutDto>();
        
            CreateMap<ContactInfoInModel, ContactInfoOutDto>();
            CreateMap<AddressInfoInModel, AddressInfoOutDto>();
            CreateMap<FinancialInfoInModel, FinancialInfoOutDto>();
            CreateMap<EmploymentInfoInModel, EmploymentInfoOutDto>();
            CreateMap<ForeignCurrencyAccountInModel, ForeignCurrencyAccountOutDto>();
            CreateMap<InterviewInfoInModel, InterviewInfoOutDto>();
            CreateMap<ReferenceInModel, Domain.Dto.Out.ReferenceOutDto>();
            CreateMap<DescriptionInfoInModel, DescriptionInfoOutDto>();
        }

        private class CustomerInModel
        {
        }

        private class BasicInformationInModel
        {
        }

        private class IdentificationInModel
        {
        }

        private class BirthInfoInModel
        {
        }

        private class FinancialInfoInModel
        {
        }

        private class ContactInfoInModel
        {
        }

        private class EmploymentInfoInModel
        {
        }

        private class DescriptionInfoInModel
        {
        }

        private class ReferenceInModel
        {
        }

        private class InterviewInfoInModel
        {
        }

        private class ForeignCurrencyAccountInModel
        {
        }
    }

    internal class AddressInfoInModel
    {
    }
}
