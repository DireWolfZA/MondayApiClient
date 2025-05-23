namespace MondayApi.Schema {
    [GraphQlObjectType("PrimitiveInputFieldConfig")]
    public class PrimitiveInputFieldConfig : IInputFieldConfig {
        public int? ID { get; set; }
        public string? FieldKey { get; set; }
        public string? FieldTitle { get; set; }
        public bool? IsNullable { get; set; }
        public bool? IsArray { get; set; }
        public bool? IsOptional { get; set; }
        public FieldInformation? Information { get; set; }
        public FieldInformation? Description { get; set; }
        public FieldTypeRelationType? Type { get; set; }
        public PrimitiveTypes? PrimitiveType { get; set; }
    }
}
