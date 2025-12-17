using System.Collections.Generic;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{Type.ToString(),nq}:{ID}: {Text}")]
    [GraphQlObjectType("DropdownValue")]
    public class DropdownValue : AddShallowCopy<IColumnValue>, IMirroredValue, IColumnValue {
        public Column? Column { get; set; }
        public string? ID { get; set; }
        public string? Text { get; set; }
        public ColumnType? Type { get; set; }
        public object? Value { get; set; }
        public ICollection<DropdownValueOption>? Values { get; set; }
    }

    internal class DropdownValueForUpdate { // https://developer.monday.com/api-reference/reference/dropdown#json
        public ICollection<string?>? IDs { get; set; }
        public ICollection<string?>? Labels { get; set; }
    }
}
