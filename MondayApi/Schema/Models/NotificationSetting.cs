using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class NotificationSetting {
        public string? Kind { get; set; }
        public string? Description { get; set; }
        [JsonProperty("is_for_admins_only")]
        public bool? IsForAdminsOnly { get; set; }
        [JsonProperty("is_for_non_guests_only")]
        public bool? IsForNonGuestsOnly { get; set; }
        public ICollection<NotificationSettingChannel>? Channels { get; set; }
    }
}
