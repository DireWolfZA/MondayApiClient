using System.Collections.Generic;

namespace MondayApi.Schema {
    public interface IFieldType {
        int? ID { get; set; }
        string? Name { get; set; }
        string? Description { get; set; }
        FieldTypeState? State { get; set; }
        string? Key { get; set; }
        string? DefaultFieldKey { get; set; }
        DependencyConfig? DependencyConfig { get; set; }
        ICollection<FieldTypeImplementation>? Implement { get; set; }
    }
}
