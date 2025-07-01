using AutoMapper;
using Domain.Dtos.CreateSavingsAccount.In;
using Domain.Dtos.CreateSavingsAccount.Out;
using Domain.Models.CreateSavingsAccount.Out;

namespace Application.Mappers;

public class CreateCustomerMappingsProfile : Profile
{
    public CreateCustomerMappingsProfile() => CreateMapping();

    private void CreateMapping()
    {
        // Create IN
        CreateMap<CustomerCreateInDto, CustomerCreateInModel>();
        CreateMap<BasicInformationDto, BasicInformationModel>();
        CreateMap<IdentificationDto, IdentificationModel>();
        CreateMap<BirthDto, BirthModel>();
        CreateMap<ContactDto, ContactModel>();
        CreateMap<AddressDto, AddressModel>();
        CreateMap<FinancialDto, FinancialModel>();
        CreateMap<EmploymentDto, EmploymentModel>();
        CreateMap<BakingInfoDto, BakingModel>();
        CreateMap<InterviewDto, InterviewModel>();
        CreateMap<ReferenceDto, ReferenceModel>();
        CreateMap<DescriptionDto, DescriptionModel>();

        // Create OUT 
        CreateMap<CustomerCreateOutDto, CustomerCreateOutModel>();
        CreateMap<BasicInformationOutDto, BasicInformationOutModel>();
        CreateMap<IdentificationOutDto, IdentificationOutModel>();
        CreateMap<BirthOutDto, BirthOutModel>();
        CreateMap<ContactOutDto, ContactOutModel>();
        CreateMap<AddressOutDto, AddressOutModel>();
        CreateMap<FinancialOutDto, FinancialOutModel>();
        CreateMap<EmploymentOutDto, EmploymentOutModel>();
        CreateMap<FulfillmentOutDto, FulfillmentOutModel>();
        CreateMap<InterviewOutDto, InterviewOutModel>();
        CreateMap<ReferenceOutDto, ReferenceOutModel>();
        CreateMap<DescriptionOutDto, DescriptionOutModel>();
    }

    private void CreateMap<T1, T2>()
    {
        throw new NotImplementedException();
    }

    private class BasicInformationDto
    {
    }

    private class IdentificationDto
    {
    }

    private class BirthDto
    {
    }

    private class AddressDto
    {
    }

    private class ContactDto
    {
    }

    private class FinancialDto
    {
    }

    private class EmploymentDto
    {
    }

    private class FulfillmentDto
    {
    }

    private class CustomerCreateInModel
    {
    }

    private class BasicInformationModel
    {
    }

    private class IdentificationModel
    {
    }

    private class BirthModel
    {
    }

    private class ContactModel
    {
    }

    private class AddressModel
    {
    }

    private class FinancialModel
    {
    }

    private class EmploymentModel
    {
    }

    private class BakingInfoDto
    {
    }

    private class BakingModel
    {
    }

    private class InterviewDto
    {
    }

    private class ReferenceDto
    {
    }

    private class ReferenceModel
    {
    }

    private class InterviewModel
    {
    }

    private class DescriptionDto
    {
    }

    private class DescriptionModel
    {
    }

    private class BasicInformationOutDto
    {
    }

    private class IdentificationOutDto
    {
    }

    private class BirthOutModel
    {
    }

    private class BirthOutDto
    {
    }

    private class BasicInformationOutModel
    {
    }

    private class IdentificationOutModel
    {
    }

    private class ContactOutModel
    {
    }

    private class ContactOutDto
    {
    }

    private class AddressOutDto
    {
    }

    private class FinancialOutDto
    {
    }

    private class EmploymentOutDto
    {
    }

    private class AddressOutModel
    {
    }

    private class FinancialOutModel
    {
    }

    private class EmploymentOutModel
    {
    }

    private class InterviewOutDto
    {
    }

    private class FulfillmentOutDto
    {
    }

    private class FulfillmentOutModel
    {
    }

    private class InterviewOutModel
    {
    }

    private class ReferenceOutDto
    {
    }

    private class ReferenceOutModel
    {
    }

    private class DescriptionOutDto
    {
    }

    private class DescriptionOutModel
    {
    }

    private class CustomerCreateInDto
    {
    }
}
