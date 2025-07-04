using System.Text.RegularExpressions;

namespace Core.Validators;

public static class CommonValidations
{
    public static bool OrigenDeFondosInValidate(string origenDeFondos) =>
        new HashSet<string>
        {
            "010", "020", "030", "040", "050", "060", "070", "080", "090",
            "100", "110", "120", "130", "140", "150"
        }.Contains(origenDeFondos);

    public static bool CodigoConceptoInValidate(string concepto) =>
        new HashSet<string> { "01", "02", "03", "04", "05", "06", "07" }.Contains(concepto);

    public static bool ClaseCertificadoInValidate(int claseCertificado) =>
        new HashSet<int> { 1 }.Contains(claseCertificado);

    public static bool UnidadDuracionInValidate(string unidadDuracion) =>
        new HashSet<string> { "D", "M", "Y" }.Contains(unidadDuracion);

    public static bool UnidadFrecuenciaPagoInteresInValidate(string unidadFrecuenciaPagoInteres) =>
        new HashSet<string> { "D", "M", "Y" }.Contains(unidadFrecuenciaPagoInteres);

    public static bool InstruccionProrrogaInValidate(string instruccionProrroga) =>
        new HashSet<string> { "P" }.Contains(instruccionProrroga);

    public static bool ViaPagoInValidate(string viaPago) =>
        new HashSet<string> { "", "C", "R", "G", "1", "2", "3" }.Contains(viaPago);

    public static bool TipoTasaInValidate(string tipoTasa) =>
        new HashSet<string> { " ", "1" }.Contains(tipoTasa);

    public static bool BancoInValidate(string banco) =>
        new HashSet<string> { "01" }.Contains(banco);

    public static bool FechaValidate(int anio, int mes, int dia)
    {
        try
        {
            _ = new DateTime(anio, mes, dia, 0, 0, 0, DateTimeKind.Utc);
            return true;
        }
        catch (ArgumentOutOfRangeException)
        {
            return false;
        }
    }

    public static bool ColombianPhone(string phone) =>
        Regex.IsMatch(phone, @"^3\d{9}$");

    public static bool Alphanumeric(string input) =>
        Regex.IsMatch(input, @"^[a-zA-Z0-9\s\-_,.]+$");
}
