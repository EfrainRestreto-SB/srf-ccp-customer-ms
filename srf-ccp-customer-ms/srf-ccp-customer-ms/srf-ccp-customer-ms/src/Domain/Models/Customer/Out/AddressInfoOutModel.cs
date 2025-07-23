using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class AddressInfoOutModel
    {
        public string AddressLine1 { get; set; }           // E01NA2 - Dirección principal (max 45 alfanumérico)
        public string AddressLine2 { get; set; }           // E01NA3 - Dirección complementaria (max 45 alfanumérico)
        public string AddressLine3 { get; set; }           // E01NA4 - Barrio u observaciones (max 45 alfanumérico)
        public string City { get; set; }                   // E01CTY - Ciudad (max 35 alfanumérico)
        public string CityCode { get; set; }               // E01STE - Código ciudad (max 4 alfanumérico)
        public string Country { get; set; }                // E01CTR - País (max 35 alfanumérico)
        public string PostalCode { get; set; }             // E01ZPC - Código postal (max 15 alfanumérico)
        public string ResidenceCountry { get; set; }       // E01GEC - País de residencia (max 4 alfanumérico)
        public int CurrentResidenceYears { get; set; }     // E01TVY - Años en vivienda actual (max 2 numérico)
        public int CurrentResidenceMonths { get; set; }    // E01TVM - Meses en vivienda actual (max 2 numérico)
        public string HousingType { get; set; }            // E01VIV - Tipo de vivienda (max 4 alfanumérico, tabla de referencia)
    }
}
