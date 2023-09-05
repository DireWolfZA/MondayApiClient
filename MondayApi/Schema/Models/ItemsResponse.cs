using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ItemsResponse {
        public string Cursor { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
