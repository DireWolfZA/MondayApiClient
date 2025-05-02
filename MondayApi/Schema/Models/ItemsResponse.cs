using System.Collections.Generic;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("Items:{Items.Count} Cursor:{Cursor}")]
    public class ItemsResponse {
        public string? Cursor { get; set; }
        public ICollection<Item>? Items { get; set; }
    }
}
