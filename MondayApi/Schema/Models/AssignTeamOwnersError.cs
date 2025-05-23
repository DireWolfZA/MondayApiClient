using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AssignTeamOwnersError {
        public string? Message { get; set; }
        public AssignTeamOwnersErrorCode? Code { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
    }
}
