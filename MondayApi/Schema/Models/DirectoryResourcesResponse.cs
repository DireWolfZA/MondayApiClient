using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DirectoryResourcesResponse {
        public string? ID { get; set; }
        public ICollection<DirectoryResource>? Resources { get; set; }
        public string? Cursor { get; set; }
    }
}
