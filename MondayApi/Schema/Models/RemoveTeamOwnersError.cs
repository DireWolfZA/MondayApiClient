using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class RemoveTeamOwnersError {
        public string? Message { get; set; }
        public RemoveTeamOwnersErrorCode? Code { get; set; }
        [JsonProperty("user_id")]
        public string? UserID { get; set; }
    }
}
