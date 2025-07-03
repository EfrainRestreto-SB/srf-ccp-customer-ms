using SrfCcpCustomerMs.Domain.Entities;

namespace SrfCcpCustomerMs.Application.Mappers
{
    public static class CreateCustomerMappings
    {
        public static Customer ToEntity(CustomerDto dto, string id)
        {
            return new Customer
            {
                Id = id,
                FullName = $"{dto.FirstName} {dto.SecondName} {dto.FirstLastName} {dto.SecondLastName}",
                IdNumber = dto.IdNumber,
                IdType = dto.IdType,
                Email = dto.Email,
                Phone = dto.Phone,
                Gender = dto.Gender
            };
        }
    }
}
