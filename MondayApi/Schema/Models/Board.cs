using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Name}")]
    [GraphQlObjectType("Board")]
    public class Board : IMirroredValue {
        public string? ID { get; set; }
        public ICollection<Update>? Updates { get; set; }
        [JsonProperty("activity_logs")]
        public ICollection<ActivityLogType?>? ActivityLogs { get; set; }
        [JsonProperty("board_folder_id")]
        public string? BoardFolderID { get; set; }
        [JsonProperty("board_kind")]
        public BoardKind? BoardKind { get; set; }
        public ICollection<Column?>? Columns { get; set; }
        [JsonProperty("columns_namespace")]
        public string? ColumnsNamespace { get; set; }
        public object? Communication { get; set; }
        public User? Creator { get; set; }
        public string? Description { get; set; }
        public ICollection<Group?>? Groups { get; set; }
        [JsonProperty("item_terminology")]
        public string? ItemTerminology { get; set; }
        [JsonProperty("items_count")]
        public int? ItemsCount { get; set; }
        [JsonProperty("items_limit")]
        public int? ItemsLimit { get; set; }
        [JsonProperty("items_page")]
        public ItemsResponse? ItemsPage { get; set; }
        public string? Name { get; set; }
        public ICollection<User?>? Owners { get; set; }
        public string? Permissions { get; set; }
        public State? State { get; set; }
        public ICollection<User?>? Subscribers { get; set; }
        public ICollection<Tag?>? Tags { get; set; }
        [JsonProperty("team_owners")]
        public ICollection<Team>? TeamOwners { get; set; }
        [JsonProperty("team_subscribers")]
        public ICollection<Team>? TeamSubscribers { get; set; }
        [JsonProperty("top_group")]
        public Group? TopGroup { get; set; }
        public BoardObjectType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? URL { get; set; }
        public ICollection<BoardView?>? Views { get; set; }
        public Workspace? Workspace { get; set; }
        [JsonProperty("workspace_id")]
        public string? WorkspaceID { get; set; }
    }
}
