using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class DeactivateUsersError {
        public string? Message { get; set; }
        public DeactivateUsersErrorCode? Code { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
    }
}
