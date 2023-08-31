// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace MondayApi.Schema
{
    public class Board
    {
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("activity_logs")]
        #endif
        public ICollection<ActivityLogType> ActivityLogs { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("board_folder_id")]
        #endif
        public int? BoardFolderId { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("board_kind")]
        #endif
        public BoardKind? BoardKind { get; set; }
        public ICollection<Column> Columns { get; set; }
        public object Communication { get; set; }
        public User Creator { get; set; }
        public string Description { get; set; }
        public ICollection<Group> Groups { get; set; }
        public Guid? Id { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("item_terminology")]
        #endif
        public string ItemTerminology { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("items_count")]
        #endif
        public int? ItemsCount { get; set; }
        public string Name { get; set; }
        public ICollection<User> Owners { get; set; }
        public string Permissions { get; set; }
        public State? State { get; set; }
        public ICollection<User> Subscribers { get; set; }
        public ICollection<Tag> Tags { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("team_owners")]
        #endif
        public ICollection<Team> TeamOwners { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("top_group")]
        #endif
        public Group TopGroup { get; set; }
        public BoardObjectType? Type { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("updated_at")]
        #endif
        public DateTimeOffset? UpdatedAt { get; set; }
        public ICollection<Update> Updates { get; set; }
        public ICollection<BoardView> Views { get; set; }
        public Workspace Workspace { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("workspace_id")]
        #endif
        public int? WorkspaceId { get; set; }
    }
}
