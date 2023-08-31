using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ColumnValue {
        [JsonProperty("additional_info")]
        public object AdditionalInfo { get; set; }
        public string Description { get; set; }
        public Guid? Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public object Value { get; set; }
    }
}
