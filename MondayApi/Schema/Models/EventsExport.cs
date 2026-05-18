using System.Collections.Generic;

namespace MondayApi.Schema {
    public class EventsExport {
        public ICollection<Event>? Events { get; set; }
        public int? Total { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }
}
