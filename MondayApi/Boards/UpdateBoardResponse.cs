using Newtonsoft.Json;

namespace MondayApi.Boards {
    // https://developer.monday.com/api-reference/docs/boards#update-a-board
    public class UpdateBoardResponse {
        public bool Success { get; set; }
        [JsonProperty("undo_data")]
        public UpdateUndoData UndoData { get; set; }

        public class UpdateUndoData {
            [JsonProperty("undo_record_id")]
            public long UndoRecordID { get; set; }
            [JsonProperty("action_type")]
            public string ActionType { get; set; }
            [JsonProperty("entity_type")]
            public string EntityType { get; set; }
            [JsonProperty("entity_id")]
            public string EntityID { get; set; }
            public int Count { get; set; }
        }
    }
}
