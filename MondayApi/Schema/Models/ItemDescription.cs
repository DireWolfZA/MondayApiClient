using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ItemDescription {
        public ICollection<DocumentBlock?>? Blocks { get; set; }
        public string? ID { get; set; }
    }
}
