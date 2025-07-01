namespace Core.Validators;

public static class CommonValidations
{
    public static bool OrigenDeFondosInValidate(string origenDeFondos)
    {
        HashSet<string> valoresValidos =
        [
            "010", "020", "030", "040", "050", "060", "070", "080", "090",
            "100", "110", "120", "130", "140", "150"
        ];

        return valoresValidos.Contains(origenDeFondos);
    }

    public static bool CodigoConceptoInValidate(string concepto)
    {
        HashSet<string> valoresValidos = ["01", "02", "03", "04", "05", "06", "07"];

        return valoresValidos.Contains(concepto);
    }

    public static bool ClaseCertificadoInValidate(int claseCertificado)
    {
        HashSet<int> valoresValidos = [1];

        return valoresValidos.Contains(claseCertificado);
    }

    public static bool UnidadDuracionInValidate(string unidadDuracion)
    {
        HashSet<string> valoresValidos = ["D", "M", "Y"];

        return valoresValidos.Contains(unidadDuracion);
    }

    public static bool UnidadFrecuenciaPagoInteresInValidate(string unidadFrecuenciaPagoInteres)
    {
        HashSet<string> valoresValidos = ["D", "M", "Y"];

        return valoresValidos.Contains(unidadFrecuenciaPagoInteres);
    }

    public static bool InstruccionProrrogaInValidate(string instruccionProrroga)
    {
        HashSet<string> valoresValidos = ["P"];

        return valoresValidos.Contains(instruccionProrroga);
    }

    public static bool ViaPagoInValidate(string viaPago)
    {
        HashSet<string> valoresValidos = ["", "C", "R", "G", "1", "2", "3"];

        return valoresValidos.Contains(viaPago);
    }

    public static bool TipoTasaInValidate(string tipoTasa)
    {
        HashSet<string> valoresValidos = [" ", "1"];

        return valoresValidos.Contains(tipoTasa);
    }

    public static bool BancoInValidate(string banco)
    {
        HashSet<string> valoresValidos = ["01"];

        return valoresValidos.Contains(banco);
    }

    public static bool FechaValidate(int anio, int mes, int dia)
    {
        try
        {
            _ = new DateTime(anio, mes, dia, 0, 0, 0, DateTimeKind.Utc); // Se especifica DateTimeKind
            return true;
        }
        catch (ArgumentOutOfRangeException) // Capturamos solo excepciones esperadas
        {
            return false;
        }
    }

}
