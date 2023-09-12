using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Columns {
    public class ColumnSettings {
        [JsonProperty("allowMultipleItems")]
        public bool AllowMultipleItems { get; set; }
        [JsonProperty("itemTypeName")]
        public string ItemTypeName { get; set; }
        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
        [JsonProperty("boardIds")]
        public ICollection<string> BoardIDs { get; set; }
    }
}
