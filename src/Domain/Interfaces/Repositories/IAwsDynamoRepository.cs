using Domain.Dtos;

namespace Domain.Interfaces.Repositories;

public interface IAwsDynamoRepository
{
    public Task<List<CreateCustomerOutDto>> GetCdtList();
    public Task InsertCreateCdtAsync(CreateCustomerOutDto createCdt);
    public Task<CreateCustomerOutDto?> GetCdtListByIdAsync(string id);
}
