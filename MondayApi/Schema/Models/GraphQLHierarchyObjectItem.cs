using System;

namespace MondayApi.Schema {
    public class GraphQLHierarchyObjectItem {
        public string? ID { get; set; }
        public string? AccountID { get; set; }
        public HierarchyObjectID? Object { get; set; }
        public string? FolderID { get; set; }
        public decimal? Position { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
