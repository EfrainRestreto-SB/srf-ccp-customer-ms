

namespace Domain.Models.CreateSavingsAccount.Out;

public class DatosUbicacionOutModel
{
    public string? CodigoDpto { get; set;}
    public string? CodigoMunicipio { get; set;}
    public string? Direccion { get; set;}
    public string? TipoTelefono { get; set;}
    public string? NumeroTelefonoPrincipal { get; set;}
    public InformacionExpedicionIdentificacionOutModel? InformacionExpedicionIdentificacion { get; set;}
}
