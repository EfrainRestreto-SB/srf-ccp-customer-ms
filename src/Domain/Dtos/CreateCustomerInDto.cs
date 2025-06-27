using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class CreateCustomerInDto
    {
        [JsonPropertyName("tipoIdentificacion")]
        public string? TipoIdentificacion { get; set; }

        [JsonPropertyName("numeroIdentificacion")]
        public string? NumeroIdentificacion { get; set; }

        [JsonPropertyName("primerNombre")]
        public string? PrimerNombre { get; set; }

        [JsonPropertyName("segundoNombre")]
        public string? SegundoNombre { get; set; }

        [JsonPropertyName("primerApellido")]
        public string? PrimerApellido { get; set; }

        [JsonPropertyName("segundoApellido")]
        public string? SegundoApellido { get; set; }

        [JsonPropertyName("genero")]
        public string? Genero { get; set; }

        [JsonPropertyName("estadoCivil")]
        public string? EstadoCivil { get; set; }

        [JsonPropertyName("nacionalidad")]
        public string? Nacionalidad { get; set; }

        [JsonPropertyName("fechaNacimiento")]
        public string? FechaNacimiento { get; set; }

        [JsonPropertyName("correoElectronico")]
        public string? CorreoElectronico { get; set; }

        [JsonPropertyName("celular")]
        public string? Celular { get; set; }

        [JsonPropertyName("direccion")]
        public string? Direccion { get; set; }

        [JsonPropertyName("ciudad")]
        public string? Ciudad { get; set; }

        [JsonPropertyName("departamento")]
        public string? Departamento { get; set; }

        [JsonPropertyName("pais")]
        public string? Pais { get; set; }

        [JsonPropertyName("fechaExpedicion")]
        public string? FechaExpedicion { get; set; }

        [JsonPropertyName("lugarExpedicion")]
        public string? LugarExpedicion { get; set; }
    }
}
