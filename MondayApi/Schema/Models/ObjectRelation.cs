using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ObjectRelation {
        public string? ID { get; set; }
        [JsonProperty("source_object_id")]
        public string? SourceObjectID { get; set; }
        [JsonProperty("target_id")]
        public string? TargetID { get; set; }
        [JsonProperty("target_object_type")]
        public TargetObject? TargetObjectType { get; set; }
        public string? Kind { get; set; }
    }
}
