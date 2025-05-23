namespace MondayApi.Schema {
    public interface IInputFieldConfig {
        int? ID { get; set; }
        string? FieldKey { get; set; }
        string? FieldTitle { get; set; }
        bool? IsNullable { get; set; }
        bool? IsArray { get; set; }
        bool? IsOptional { get; set; }
        FieldInformation? Information { get; set; }
        FieldInformation? Description { get; set; }
        FieldTypeRelationType? Type { get; set; }
    }
}
