using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BlockEventsPage {
        public ICollection<BlockEvent>? BlockEvents { get; set; }
    }
}
