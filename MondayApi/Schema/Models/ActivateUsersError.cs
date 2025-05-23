using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class ActivateUsersError {
        public string? Message { get; set; }
        public ActivateUsersErrorCode? Code { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
    }
}
