using System.Collections.Generic;

namespace MondayApi.Schema {
    [GraphQlObjectType("PrimitiveFieldType")]
    public class PrimitiveFieldType : IFieldType {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public FieldTypeState? State { get; set; }
        public string? Key { get; set; }
        public string? DefaultFieldKey { get; set; }
        public DependencyConfig? DependencyConfig { get; set; }
        public ICollection<FieldTypeImplementation>? Implement { get; set; }
        public PrimitiveTypes? PrimitiveType { get; set; }
        public object? ConfigurartionMetadata { get; set; }
    }
}
