namespace Domain.Models.Customer
{
    public class EmploymentInfoInModel
    {
        public string CompanyName { get; set; }             // E01CP1  - max 45 alfanumérico
        public string CompanyAddress { get; set; }          // E01CP2  - max 45 alfanumérico
        public string JobPosition { get; set; }             // E01CP3  - max 45 alfanumérico (Tabla 32, primeras 4 posiciones)
        public string PreviousCompany { get; set; }         // E01NM4  - max 45 alfanumérico

        public int EmploymentStartMonth { get; set; }       // E01SWM  - max 2 numérico
        public int EmploymentStartDay { get; set; }         // E01SWD  - max 2 numérico
        public int EmploymentStartYear { get; set; }        // E01SWY  - max 4 numérico

        public string CompanyCityCode { get; set; }         // E01F01  - max 4 alfanumérico (Tabla 84)
        public string CompanyCountry { get; set; }          // E01F02  - max 4 alfanumérico (Tabla 03)
        public string ContractType { get; set; }            // E01EPT  - max 4 alfanumérico (Tabla N3)
        public string DepartmentCode { get; set; }          // E01FC4  - max 4 alfanumérico (Tabla 27)

        public string WorkPhone { get; set; }               // E01PHO1 - max 15 numérico
        public string WorkExtension { get; set; }           // E01EX01 - max 10 alfanumérico

        public int PreviousJobYears { get; set; }           // E01TIY  - max 2 numérico
        public int PreviousJobMonths { get; set; }          // E01TIM  - max 2 numérico

        public int EmployeesCount { get; set; }             // E01NEM  - max 5 numérico
        public string OccupationCode { get; set; }          // E01ALB  - max 4 alfanumérico (Tabla C4)
        public int DependentsCount { get; set; }            // E01NSO  - max 2 numérico
    }
}
