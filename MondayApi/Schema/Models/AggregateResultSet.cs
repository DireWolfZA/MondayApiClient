using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateResultSet {
        public ICollection<AggregateResultEntry>? Entries { get; set; }
    }
}
