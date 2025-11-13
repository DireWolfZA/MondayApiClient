using System;

namespace MondayApi.Schema {
    public class GraphQLFolder {
        public string? ID { get; set; }
        public string? AccountID { get; set; }
        public string? Name { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
    }
}
