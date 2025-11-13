using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Pagination {
        public int? Page { get; set; }
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        [JsonProperty("has_more_pages")]
        public bool? HasMorePages { get; set; }
        [JsonProperty("next_page_number")]
        public int? NextPageNumber { get; set; }
    }
}
