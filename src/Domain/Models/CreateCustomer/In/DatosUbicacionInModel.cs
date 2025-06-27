

namespace Domain.Models.CreateSavingsAccount.In;

public class DatosUbicacionInModel
{
    public string? CodigoDpto { get; set;}
    public string? CodigoMunicipio { get; set;}
    public string? Direccion { get; set;}
    public string? TipoTelefono { get; set;}
    public string? NumeroTelefonoPrincipal { get; set;}
    public InformacionExpedicionIdentificacionInModel? InformacionExpedicionIdentificacion { get; set;}
}
