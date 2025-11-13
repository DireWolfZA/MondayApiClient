namespace MondayApi.Schema {
    public class MarketplaceSearchHit {
        public string? ID { get; set; }
        public decimal? Score { get; set; }
        public MarketplaceSearchAppDocument? Document { get; set; }
    }
}
