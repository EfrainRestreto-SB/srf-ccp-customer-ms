<<<<<<< Updated upstream
﻿namespace Domain.Dto.Out
{
    public class EmploymentInfoOutDto
    {
        public string CompanyName { get; set; }
        public string CompanyNit { get; set; }
        public string JobAddress { get; set; }
        public string Phone { get; set; }
        public string EmploymentStatus { get; set; }
        public string EmploymentStartDate { get; set; }
        public string EmploymentContractType { get; set; }
        public string EmploymentType { get; set; }
        public string JobTitle { get; set; }
        public string EconomicSector { get; set; }
        public string EconomicActivity { get; set; }
    }
=======
﻿using System.Text.Json.Serialization;

public class EmploymentInfoOutDto
{
    [JsonPropertyName("companyName")]
    public string CompanyName { get; set; } // E01CP1 - NOMBRE DE LA EMPRESA

    [JsonPropertyName("companyAddress")]
    public string CompanyAddress { get; set; } // E01CP2 - DIRECCION EMPRESA

    [JsonPropertyName("jobPosition")]
    public string JobPosition { get; set; } // E01CP3 - CARGO EN LA EMPRESA

    [JsonPropertyName("previousCompany")]
    public string PreviousCompany { get; set; } // E01NM4 - EMPRESA ANTERIOR

    [JsonPropertyName("employmentStartMonth")]
    public int EmploymentStartMonth { get; set; } // E01SWM - FECHA VINCULACION MES

    [JsonPropertyName("employmentStartDay")]
    public int EmploymentStartDay { get; set; } // E01SWD - FECHA VINCULACION DIA

    [JsonPropertyName("employmentStartYear")]
    public int EmploymentStartYear { get; set; } // E01SWY - FECHA VINCULACION AÑO

    [JsonPropertyName("companyCityCode")]
    public string CompanyCityCode { get; set; } // E01F01 - CIUDAD DE LA EMPRESA

    [JsonPropertyName("companyCountry")]
    public string CompanyCountry { get; set; } // E01F02 - PAIS DE LA EMPRESA

    [JsonPropertyName("contractType")]
    public string ContractType { get; set; } // E01EPT - TIPO CONTRATO

    [JsonPropertyName("departmentCode")]
    public string DepartmentCode { get; set; } // E01FC4 - DEPARTAMENTO DE LA EMPRESA

    [JsonPropertyName("workPhone")]
    public string WorkPhone { get; set; } // E01PHO1 - TELEFONO

    [JsonPropertyName("workExtension")]
    public string WorkExtension { get; set; } // E01EX01 - EXTENSION

    [JsonPropertyName("previousJobYears")]
    public int PreviousJobYears { get; set; } // E01TIY - ANTIGÜEDAD AÑOS EMP. ANTERIOR

    [JsonPropertyName("previousJobMonths")]
    public int PreviousJobMonths { get; set; } // E01TIM - ANTIGÜEDAD MESES EMP. ANTERIOR

    [JsonPropertyName("employeesCount")]
    public int EmployeesCount { get; set; } // E01NEM - CANTIDAD DE EMPLEADOS

    [JsonPropertyName("occupationCode")]
    public string OccupationCode { get; set; } // E01ALB - CODIGO OCUPACION

    [JsonPropertyName("dependentsCount")]
    public int DependentsCount { get; set; } // E01DEP - NRO. DE PERSONAS A CARGO (Este campo lo infiero por el nombre, pero si tienes código AS400 exacto lo ajusto)
>>>>>>> Stashed changes
}
