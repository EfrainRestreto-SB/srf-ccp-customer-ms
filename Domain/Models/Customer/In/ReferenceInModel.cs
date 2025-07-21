namespace Domain.Models.Customer
{
    public class ReferenceInModel
    {
        public string ReferenceType { get; set; }           // Máx 1 - P, F, 7
        public string CompanyName { get; set; }             // Máx 60 - Solo si es Comercial
        public string ContactName { get; set; }             // Máx 80
        public string FirstLastName { get; set; }           // Máx 80
        public string SecondLastName { get; set; }          // Máx 80
        public string CountryCode { get; set; }             // Máx 35 - Tabla 03
        public string DepartmentCode { get; set; }          // Máx 4 - Tabla 27
        public string CityCode { get; set; }                // Máx 4 - Tabla 84
        public string LandlinePhone { get; set; }           // Máx 15 - numérico
        public string MobilePhone { get; set; }             // Máx 15 - numérico
        public string PhoneExtension { get; set; }          // Máx 15 - numérico
        public string Relationship { get; set; }            // Máx 4 - Tabla 9W
    }
}
