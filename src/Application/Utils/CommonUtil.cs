namespace Application.Utils
{
    public static class CommonUtil
    {
        /// <summary>
        /// Verifica si una cadena es nula o está vacía (incluye espacios en blanco).
        /// </summary>
        public static bool IsNullOrEmpty(string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Capitaliza la primera letra de la cadena y pone el resto en minúsculas.
        /// Devuelve cadena vacía si la entrada es nula o whitespace.
        /// </summary>
        public static string Capitalize(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            value = value.Trim();
            return char.ToUpperInvariant(value[0]) + value.Substring(1).ToLowerInvariant();
        }

        /// <summary>
        /// Normaliza un texto: recorta espacios y convierte todo a mayúsculas invariante.
        /// </summary>
        public static string NormalizeText(string? value)
        {
            return string.IsNullOrWhiteSpace(value)
                ? string.Empty
                : value.Trim().ToUpperInvariant();
        }

        /// <summary>
        /// Convierte un número nulo a su valor por defecto (0).
        /// </summary>
        public static int GetValueOrDefault(int? value, int defaultValue = 0)
        {
            return value ?? defaultValue;
        }

        /// <summary>
        /// Verifica si una lista es nula o no tiene elementos.
        /// </summary>
        public static bool IsNullOrEmpty<T>(IEnumerable<T>? collection)
        {
            return collection == null || !collection.Any();
        }

        /// <summary>
        /// Try parse de entero con valor por defecto si falla.
        /// </summary>
        public static int SafeParseInt(string? value, int defaultValue = 0)
        {
            if (int.TryParse(value, out var result))
                return result;
            return defaultValue;
        }
    }
}
