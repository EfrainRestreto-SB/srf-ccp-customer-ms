using Core.Config.SettingFile.AwsKasfa;
using Domain.Entities;

namespace Core.Mapper
{
    public static class CreateCustomerMappings
    {
        public static Cliente ToClienteEntity(KafkaCreateCustomerEvtJson dto)
        {
            return new Cliente
            {
                TipoIdentificacion = dto.TipoIdentificacion,
                NumeroIdentificacion = dto.NumeroIdentificacion,
                PrimerNombre = dto.PrimerNombre,
                PrimerApellido = dto.PrimerApellido,
                Genero = dto.Genero,
                EstadoCivil = dto.EstadoCivil,
                Nacionalidad = dto.Nacionalidad
            };
        }
    }
}
