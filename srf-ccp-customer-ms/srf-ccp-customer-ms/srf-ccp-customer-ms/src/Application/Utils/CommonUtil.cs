namespace Application.Utils;

public static class CommonUtil
{
    public static string GenerateNewClientId()
    {
        DateTime now = DateTime.Now;
        Random random = new();
        return now.ToString("yyMMddHHmmss") + random.Next(1111, 9999);
    }

    public static bool ValidateClientIdFormat(string clientId)
    {
        if (clientId.Length != 16 || !clientId.All(char.IsDigit))
            return false;

        // Extraer la parte de fecha (primeros 12 dígitos)
        string datePart = clientId.Substring(0, 12);

        try
        {
            DateTime.ParseExact(datePart, "yyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
