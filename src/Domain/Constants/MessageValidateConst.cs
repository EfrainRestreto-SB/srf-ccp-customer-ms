namespace Domain.Constants
{
    public static class MessageValidateConst
    {
        public const string NullMessage = "El valor no puede ser nulo.";
        public const string EmptyMessage = "El valor no puede estar vacío.";
        public const string IntegerLessThanOrEqualTo = "La cantidad de dígitos debe ser menor o igual a {0}.";
        public const string IntegerEqual = "La cantidad de dígitos debe ser exactamente {0}.";
        public const string StringLessThanOrEqualTo = "La cantidad de caracteres debe ser menor o igual a {0}.";
        public const string CantIntegersDecimals = "El campo debe tener un máximo de {0} dígitos enteros y {1} decimales.";

        public const string InvalidOrigenDeFondos = "Origen de fondos inválido.";
        public const string InvalidClaseDeCertificado = "Clase de certificado inválida.";
        public const string InvalidUnidadDuracion = "Unidad de duración inválida.";
        public const string InvalidUnidadFrecuenciaPagoInteres = "Unidad de frecuencia de pago de interés inválida.";
        public const string InvalidFecha = "Fecha inválida.";
        public const string InvalidInstruccionProrroga = "Instrucción de prórroga inválida.";
        public const string InvalidViaPago = "Vía de pago inválida.";
        public const string InvalidCodigoConcepto = "Código de concepto inválido.";
        public const string InvalidBanco = "Banco inválido.";
        public const string InvalidTipoTasa = "Tipo de tasa inválido.";
    }
}
