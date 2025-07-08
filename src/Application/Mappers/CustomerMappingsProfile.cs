using Application.Interfaces;
using AutoMapper;
using Domain.Dto.In;
using Domain.Entities.Customer;
using Stripe;

namespace Application.Mappers
{
    public class CustomerMappingsProfile : Profile
    {
        public CustomerMappingsProfile()
        {
            // IN DTOs ➜ ENTITIES
            CreateMap<Domain.Dto.In.CustomerCreateOutDto, Customer>();

            CreateMap<Domain.Dto.In.BasicInformationOutDto, BasicInformation>();
            CreateMap<ContactInformationInDto, ContactInformation>();
            CreateMap<AddressInDto, Address>();
            CreateMap<DescriptionInDto, Description>();
            CreateMap<Domain.Dto.In.ReferenceOutDto, Reference>();

            // ENTITIES ➜ OUT DTOs
            CreateMap<Customer, Interfaces.CustomerCreateOutDto>();
               

            CreateMap<BasicInformation, BasicInformationOutDto>();
            CreateMap<ContactInformation, ContactInformationOutDto>();
            CreateMap<Address, AddressOutDto>();
            CreateMap<Description, DescriptionOutDto>();
            CreateMap<Reference, ReferenceOutDto>();
        }


        private void CreateMap<T1, T2>()
        {
            throw new NotImplementedException();
        }

        private class ContactInformation
        {
        }

        private class AddressInDto
        {
        }

        private class DescriptionInDto
        {
        }

        private class Description
        {
        }

        private class ContactInformationOutDto
        {
        }
    }

    internal class ContactInformationInDto
    {
    }
}
