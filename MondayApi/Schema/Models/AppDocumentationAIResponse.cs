using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class AppDocumentationAIResponse {
        public string? ID { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        [JsonProperty("conversation_id")]
        public string? ConversationID { get; set; }
    }
}
