namespace Domain.Dto.In
{
    public class foreignCurrencyInfoModel
    {
        public required string foreignTransactions { get; set; }
        public required string foreignProducts { get; set; }
        public required string transaction1Amount { get; set; }
        public required string transaction1Type { get; set; }
        public required string transaction2Amount { get; set; }
        public required string transaction2Type { get; set; }
        public required string transaction3Amount { get; set; }
        public required string transaction3Type { get; set; }
        public required string foreignBank1Name { get; set; }
        public required string foreignBank1Product { get; set; }
        public required string foreignBank1Currency { get; set; }

        public required string foreignBank1Account { get; set; }
        public required string foreignBank1Balance { get; set; }
        public required string foreignBank1Country { get; set; }
        public required string foreignBank1City { get; set; }
        public required string isForexMarketIntermediary { get; set; }
    }
}
