using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.CreateCustomer.In;
using Domain.Dtos.CreateCustomer.Out;
using Domain.Dtos.CreateSavingsAccount.Out;
using Domain.Models.CreateCustomer.In;
using Domain.Models.CreateCustomer.Out;
using CustomerCreateInModel = Domain.Models.CreateCustomer.In.CustomerCreateInModel;

namespace Application.Mappers;

public class CreateCustomerMappingsProfile : Profile
{
    public CreateCustomerMappingsProfile()
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
}

internal class IdentificationOutDto
{
}

internal class BasicInformationOutDto
{
}

internal class DescriptionDto
{
}

internal class DescriptionModel
{
}

internal class InterviewModel
{
}

internal class ReferenceModel
{
}

internal class ReferenceDto
{
}

internal class BakingModel
{
}

internal class EmploymentModel
{
}

internal class FinancialModel
{
}

internal class InterviewDto
{
}

internal class BakingInfoDto
{
}

internal class EmploymentDto
{
}

internal class FinancialDto
{
}

internal class BirthModel
{
}

internal class AddressModel
{
}

internal class ContactDto
{
}

internal class ContactModel
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
public class BirthOutDto { }
public class ContactOutDto { }
public class AddressOutDto { }
public class FinancialOutDto { }
public class EmploymentOutDto { }
public class FulfillmentOutDto { }
public class InterviewOutDto { }
public class ReferenceOutDto { }
public class DescriptionOutDto { }
public class BirthOutModel { }
public class ContactOutModel { }
public class AddressOutModel { }
public class FinancialOutModel { }
public class EmploymentOutModel { }
public class FulfillmentOutModel { }
public class InterviewOutModel { }
public class ReferenceOutModel { }
public class DescriptionOutModel { }
