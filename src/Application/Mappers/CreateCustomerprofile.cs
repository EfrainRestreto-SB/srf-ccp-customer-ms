using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.CreateCustomer.Out;
using Domain.Models.CreateCustomer.Out;

namespace Application.Mappers;

public class CreateCustomerMappingsProfile : Profile
{
    public CreateCustomerMappingsProfile()
    {
        CreateMapping();
    }

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
        CreateMap<CustomerCreateOutDto, CustomerCreateInModel>();
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
}

internal class DescriptionOutModel
{
}

internal class DescriptionOutDto
{
}

internal class ReferenceOutModel
{
}

internal class ReferenceOutDto
{
}

internal class FulfillmentOutModel
{
}

internal class InterviewOutModel
{
}

internal class InterviewOutDto
{
}

internal class FulfillmentOutDto
{
}

internal class EmploymentOutModel
{
}

internal class EmploymentOutDto
{
}

internal class FinancialOutModel
{
}

internal class AddressOutModel
{
}

internal class FinancialOutDto
{
}

internal class AddressOutDto
{
}

internal class ContactOutModel
{
}

internal class ContactOutDto
{
}

internal class BirthOutModel
{
}

internal class IdentificationOutDto
{
}

internal class BirthOutDto
{
}

internal class BasicInformationOutDto
{
}

internal class BakingModel
{
}

internal class InterviewModel
{
}

internal class ReferenceModel
{
}

internal class DescriptionModel
{
}

internal class DescriptionDto
{
}

internal class ReferenceDto
{
}

internal class InterviewDto
{
}

internal class BakingInfoDto
{
}

internal class EmploymentModel
{
}

internal class EmploymentDto
{
}

internal class FinancialModel
{
}

internal class FinancialDto
{
}

internal class AddressModel
{
}

internal class ContactModel
{
}

internal class AddressDto
{
}

internal class ContactDto
{
}

internal class BirthModel
{
}

internal class BirthDto
{
}

internal class IdentificationModel
{
}

internal class BasicInformationDto
{
}