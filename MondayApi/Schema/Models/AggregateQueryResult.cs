using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AggregateQueryResult {
        public ICollection<AggregateResultSet>? Results { get; set; }
    }
}
