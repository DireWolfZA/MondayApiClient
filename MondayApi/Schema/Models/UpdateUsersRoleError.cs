using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class UpdateUsersRoleError {
        public string? Message { get; set; }
        public UpdateUsersRoleErrorCode? Code { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
    }
}
