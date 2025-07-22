namespace Domain.Models.Customer
{
    public class ForeignCurrencyInfoInModel
    {
        public string ForeignTransactions { get; set; }        // E01FX    - max 1 (Y/N)
        public string ForeignProducts { get; set; }            // E01FXP   - max 1 (Y/N)

        public long Transaction1Amount { get; set; }           // E01FXA1  - max 15 numérico
        public string Transaction1Type { get; set; }           // E01FXT1  - max 4 alfanumérico

        public long Transaction2Amount { get; set; }           // E01FXA2  - max 15 numérico
        public string Transaction2Type { get; set; }           // E01FXT2  - max 4 alfanumérico

        public long Transaction3Amount { get; set; }           // E01FXA3  - max 15 numérico
        public string Transaction3Type { get; set; }           // E01FXT3  - max 4 alfanumérico

        public string ForeignBank1Name { get; set; }           // E01FXE1  - max 20 alfanumérico
        public string ForeignBank1Product { get; set; }        // E01FXP1  - max 20 alfanumérico
        public string ForeignBank1Currency { get; set; }       // E01FXC1  - max 3 alfanumérico (valida con maestro monedas)
        public string ForeignBank1Account { get; set; }        // E01FXN1  - max 20 alfanumérico
        public long ForeignBank1Balance { get; set; }          // E01FXPA1 - max 15 numérico
        public string ForeignBank1Country { get; set; }        // E01FXO1  - max 4 alfanumérico (Tabla 03)
        public string ForeignBank1City { get; set; }           // E01FXU1  - max 20 alfanumérico

        public string IsForexMarketIntermediary { get; set; }  // E1FL06   - max 1 (Y/N)
    }
}
