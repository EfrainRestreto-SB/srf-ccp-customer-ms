

namespace Domain.Models.CreateSavingsAccount.In;

public class DatosGeneralesInModel
{
    public string? NumeroId { get; set; }
    public string? TipoId { get; set; }
    public string? PrimerNombre{ get; set; }
    public string? SegundoNombre{ get; set; }
    public string? PrimerApellido{ get; set; }
    public string? SegundoApellido{ get; set; }
    public string? Sexo { get; set; }
    public FechaInModel? FechaNacimiento{ get; set; }
    public string? CodigoPaisNacimiento{ get; set; }
    public string? CodigoDptoNacimiento{ get; set; }
    public string? CodigoCiudadNacimiento{ get; set; }
    public string? CorreoElectronico{ get; set; }
}
