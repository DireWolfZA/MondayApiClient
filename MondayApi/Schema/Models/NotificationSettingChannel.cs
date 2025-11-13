using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class NotificationSettingChannel {
        public ChannelType? Name { get; set; }
        public bool? Enabled { get; set; }
        [JsonProperty("editable_status")]
        public ChannelEditableStatus? EditableStatus { get; set; }
    }
}
