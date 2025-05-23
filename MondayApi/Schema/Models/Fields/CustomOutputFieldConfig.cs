using Newtonsoft.Json;

namespace MondayApi.Schema {
    [GraphQlObjectType("CustomOutputFieldConfig")]
    public class CustomOutputFieldConfig : IOutputFieldConfig {
        public int? ID { get; set; }
        public string? FieldKey { get; set; }
        public string? FieldTitle { get; set; }
        public bool? IsNullable { get; set; }
        public bool? IsArray { get; set; }
        public bool? IsOptional { get; set; }
        public FieldInformation? Information { get; set; }
        public FieldInformation? Description { get; set; }
        public FieldTypeRelationType? Type { get; set; }
        public int? FieldTypeReferenceID { get; set; }
        public OutputFieldConstraints? Constraints { get; set; }
        [JsonConverter(typeof(GraphQlInterfaceJsonConverter))]
        public IFieldType? FieldTypeData { get; set; }
    }
}
