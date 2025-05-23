using System.Collections.Generic;

namespace MondayApi.Schema {
    [GraphQlObjectType("DropdownColumnSettings")]
    public class DropdownColumnSettings : IColumnSettings {
        public ManagedColumnTypes? Type { get; set; }
        public ICollection<DropdownLabel>? Labels { get; set; }
    }
}
