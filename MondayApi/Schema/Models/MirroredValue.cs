using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class MirroredValue {
        [JsonProperty("activity_logs")]
        public ICollection<ActivityLogType> ActivityLogs { get; set; }
        [JsonProperty("board_folder_id")]
        public string BoardFolderID { get; set; }
        [JsonProperty("board_kind")]
        public BoardKind? BoardKind { get; set; }
        public ICollection<Column> Columns { get; set; }
        public object Communication { get; set; }
        public User Creator { get; set; }
        public string Description { get; set; }
        public ICollection<Group> Groups { get; set; }
        public string ID { get; set; }
        [JsonProperty("item_terminology")]
        public string ItemTerminology { get; set; }
        [JsonProperty("items_count")]
        public int? ItemsCount { get; set; }
        [JsonProperty("items_page")]
        public ItemsResponse ItemsPage { get; set; }
        public string Name { get; set; }
        public ICollection<User> Owners { get; set; }
        public string Permissions { get; set; }
        public State? State { get; set; }
        public ICollection<User> Subscribers { get; set; }
        public ICollection<Tag> Tags { get; set; }
        [JsonProperty("team_owners")]
        public ICollection<Team> TeamOwners { get; set; }
        [JsonProperty("top_group")]
        public Group TopGroup { get; set; }
        public BoardObjectType? Type { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        public ICollection<Update> Updates { get; set; }
        public ICollection<BoardView> Views { get; set; }
        public Workspace Workspace { get; set; }
        [JsonProperty("workspace_id")]
        public string WorkspaceID { get; set; }
        public Column Column { get; set; }
        [JsonProperty("linked_item_ids")]
        public ICollection<Guid> LinkedItemIDs { get; set; }
        [JsonProperty("linked_items")]
        public ICollection<Item> LinkedItems { get; set; }
        public string Text { get; set; }
        public object Value { get; set; }
        public string Color { get; set; }
        public string Label { get; set; }
        public bool? Checked { get; set; }
        public Country Country { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty("creator_id")]
        public string CreatorID { get; set; }
        public string Date { get; set; }
        public string Icon { get; set; }
        public string Time { get; set; }
        public FileDocValue File { get; set; }
        public ICollection<DropdownValueOption> Values { get; set; }
        public string Email { get; set; }
        public ICollection<FileValueItem> Files { get; set; }
        public bool? Archived { get; set; }
        public bool? Deleted { get; set; }
        public string Position { get; set; }
        public string Title { get; set; }
        public int? Hour { get; set; }
        public int? Minute { get; set; }
        [JsonProperty("entity_id")]
        public string EntityID { get; set; }
        [JsonProperty("issue_api_url")]
        public Guid? IssueApiURL { get; set; }
        [JsonProperty("issue_id")]
        public string IssueID { get; set; }
        [JsonProperty("item_id")]
        public string ItemID { get; set; }
        public string Url { get; set; }
        [JsonProperty("url_text")]
        public string UrlText { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [JsonProperty("city_short")]
        public string CityShort { get; set; }
        [JsonProperty("country_short")]
        public string CountryShort { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        [JsonProperty("place_id")]
        public string PlaceID { get; set; }
        public string Street { get; set; }
        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }
        [JsonProperty("street_number_short")]
        public string StreetNumberShort { get; set; }
        [JsonProperty("street_short")]
        public string StreetShort { get; set; }
        [JsonProperty("mirrored_items")]
        public ICollection<MirroredItem> MirroredItems { get; set; }
        public decimal? Number { get; set; }
        [JsonProperty("persons_and_teams")]
        public ICollection<PeopleEntity> PersonsAndTeams { get; set; }
        [JsonProperty("country_short_name")]
        public string CountryShortName { get; set; }
        public string Phone { get; set; }
        public int? Rating { get; set; }
        public int? Index { get; set; }
        [JsonProperty("is_done")]
        public bool? IsDone { get; set; }
        [JsonProperty("label_style")]
        public StatusLabelStyle LabelStyle { get; set; }
        [JsonProperty("update_id")]
        public string UpdateID { get; set; }
        [JsonProperty("tag_ids")]
        public ICollection<int> TagIDs { get; set; }
        [JsonProperty("team_id")]
        public int? TeamID { get; set; }
        public int? Duration { get; set; }
        public ICollection<TimeTrackingHistoryItem> History { get; set; }
        public bool? Running { get; set; }
        [JsonProperty("started_at")]
        public object StartedAt { get; set; }
        public DateTimeOffset? From { get; set; }
        public DateTimeOffset? To { get; set; }
        [JsonProperty("visualization_type")]
        public string VisualizationType { get; set; }
        [JsonProperty("vote_count")]
        public int? VoteCount { get; set; }
        [JsonProperty("voter_ids")]
        public ICollection<Guid> VoterIDs { get; set; }
        [JsonProperty("end_date")]
        public object EndDate { get; set; }
        [JsonProperty("start_date")]
        public object StartDate { get; set; }
        public string Timezone { get; set; }
    }
}
