using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MarketplaceSearchResults {
        public ICollection<MarketplaceSearchHit>? Hits { get; set; }
        public int? Count { get; set; }
        public string? Elapsed { get; set; }
    }
}
