using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Block {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Kind { get; set; }
        [JsonConverter(typeof(GraphQlInterfaceJsonConverter))]
        public ICollection<IInputFieldConfig>? InputFieldsConfig { get; set; }
        [JsonConverter(typeof(GraphQlInterfaceJsonConverter))]
        public ICollection<IOutputFieldConfig>? OutputFieldsConfig { get; set; }
    }
}
