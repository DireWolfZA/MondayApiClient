using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class BoardMuteSettings {
        [JsonProperty("board_id")]
        public string? BoardID { get; set; }
        [JsonProperty("mute_state")]
        public BoardMuteState? MuteState { get; set; }
        public ICollection<CustomizableBoardSettings>? Enabled { get; set; }
    }
}
