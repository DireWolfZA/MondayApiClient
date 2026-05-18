using System;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DependencyColumnConfig {
        public string? ID { get; set; }
        [JsonProperty("account_id")]
        public string? AccountID { get; set; }
        [JsonProperty("board_id")]
        public string? BoardID { get; set; }
        public object? Data { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        [JsonProperty("config_type")]
        public string? ConfigType { get; set; }
    }
}
