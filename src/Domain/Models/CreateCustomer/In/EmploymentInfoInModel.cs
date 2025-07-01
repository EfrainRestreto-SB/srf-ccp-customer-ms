namespace Domain.Models.CreateCustomer.In;

public class EmploymentInfoInModel
{
    public string? EmployerName { get; set; }              // E01EPN
    public string? EmployerNit { get; set; }               // E01EPNI
    public string? JobCode { get; set; }                   // E01JBC
    public string? JobDescription { get; set; }            // E01JBD
    public string? JobPosition { get; set; }               // E01JBP
    public string? JobPositionDescription { get; set; }    // E01JPD
    public string? EmploymentStartDate { get; set; }       // E01JSD (yyyyMMdd)
    public string? EmployerPhone { get; set; }             // E01EPP
    public string? EmployerCity { get; set; }              // E01CDE
    public string? EmployerDepartment { get; set; }        // E01DPT
    public string? EmployerCountry { get; set; }           // E01CTY
    public string? OccupationCode { get; set; }            // E01OCC
    public string? OccupationDescription { get; set; }     // E01OCD
    public string? IndependentStatus { get; set; }         // E01IND
}
