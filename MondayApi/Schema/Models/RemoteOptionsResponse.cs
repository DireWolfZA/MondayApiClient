using System.Collections.Generic;

namespace MondayApi.Schema {
    public class RemoteOptionsResponse {
        public ICollection<Option>? Options { get; set; }
        public bool? IsPaginated { get; set; }
        public bool? IsLastPage { get; set; }
        public NextPageRequestData? NextPageRequestData { get; set; }
        public string? Disclaimer { get; set; }
    }
}
