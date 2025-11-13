using System;

namespace MondayApi.Schema {
    public class Connection {
        public int? ID { get; set; }
        public int? AccountID { get; set; }
        public int? UserID { get; set; }
        public string? Provider { get; set; }
        public string? Name { get; set; }
        public string? Method { get; set; }
        public string? ProviderAccountIdentifier { get; set; }
        public string? State { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
