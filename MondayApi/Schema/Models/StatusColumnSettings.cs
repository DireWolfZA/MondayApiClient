using System.Collections.Generic;

namespace MondayApi.Schema {
    [GraphQlObjectType("StatusColumnSettings")]
    public class StatusColumnSettings : IColumnSettings {
        public ManagedColumnTypes? Type { get; set; }
        public ICollection<StatusLabel>? Labels { get; set; }
    }
}
