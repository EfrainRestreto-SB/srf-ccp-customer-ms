using Application.DTOs.Customer;
using Application.Interfaces.Customer;
using AutoMapper;
using Core.Exceptions;
using Domain.Models.Customer.In;
using FluentValidation;
using FluentValidation.Results;
using Persistence.Cache.Interfaces;
using Persistence.Messaging.Kafka.Interfaces;
using Utils.Generators;

namespace Application.Services.Customer;

public class CustomerService : ICustomerService
{
    private readonly IValidator<CustomerCreateInDto> _validator;
    private readonly IMapper _mapper;
    private readonly IRedisService _redisService;
    private readonly IKafkaProducer _kafkaProducer;

    public CustomerService(
        IValidator<CustomerCreateInDto> validator,
        IMapper mapper,
        IRedisService redisService,
        IKafkaProducer kafkaProducer)
    {
        _validator = validator;
        _mapper = mapper;
        _redisService = redisService;
        _kafkaProducer = kafkaProducer;
    }

    public async Task<CustomerCreateOutDto> CreateCustomerAsync(CustomerCreateInDto dto)
    {
        ValidationResult result = await _validator.ValidateAsync(dto);

        if (!result.IsValid)
            throw new ValidationException("Error de validación", result.Errors);

        var model = _mapper.Map<CustomerCreateInModel>(dto);

        var id = GuidGenerator.NewId();

        await _redisService.SaveAsync(id, model);

        await _kafkaProducer.SendAsync("srf-ccp-clientes-cmd", id, model);

        return new CustomerCreateOutDto
        {
            Id = id,
            Data = new CustomerCreateOutDataDto
            {
                CustomerNumber = dto.Identification.IdNumber
            }
        };
    }
}
