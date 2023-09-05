using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Mutation {
        [JsonProperty("add_file_to_column")]
        public Asset AddFileToColumn { get; set; }
        [JsonProperty("add_file_to_update")]
        public Asset AddFileToUpdate { get; set; }
        [JsonProperty("add_teams_to_board")]
        public ICollection<Team> AddTeamsToBoard { get; set; }
        [JsonProperty("add_teams_to_workspace")]
        public ICollection<Team> AddTeamsToWorkspace { get; set; }
        [JsonProperty("add_users_to_board")]
        public ICollection<User> AddUsersToBoard { get; set; }
        [JsonProperty("add_users_to_workspace")]
        public ICollection<User> AddUsersToWorkspace { get; set; }
        [JsonProperty("archive_board")]
        public Board ArchiveBoard { get; set; }
        [JsonProperty("archive_group")]
        public Group ArchiveGroup { get; set; }
        [JsonProperty("archive_item")]
        public Item ArchiveItem { get; set; }
        [JsonProperty("change_column_metadata")]
        public Column ChangeColumnMetadata { get; set; }
        [JsonProperty("change_column_title")]
        public Column ChangeColumnTitle { get; set; }
        [JsonProperty("change_column_value")]
        public Item ChangeColumnValue { get; set; }
        [JsonProperty("change_multiple_column_values")]
        public Item ChangeMultipleColumnValues { get; set; }
        [JsonProperty("change_simple_column_value")]
        public Item ChangeSimpleColumnValue { get; set; }
        [JsonProperty("clear_item_updates")]
        public Item ClearItemUpdates { get; set; }
        public Complexity Complexity { get; set; }
        [JsonProperty("create_board")]
        public Board CreateBoard { get; set; }
        [JsonProperty("create_column")]
        public Column CreateColumn { get; set; }
        [JsonProperty("create_doc")]
        public Document CreateDoc { get; set; }
        [JsonProperty("create_doc_block")]
        public DocumentBlock CreateDocBlock { get; set; }
        [JsonProperty("create_folder")]
        public Folder CreateFolder { get; set; }
        [JsonProperty("create_group")]
        public Group CreateGroup { get; set; }
        [JsonProperty("create_item")]
        public Item CreateItem { get; set; }
        [JsonProperty("create_notification")]
        public Notification CreateNotification { get; set; }
        [JsonProperty("create_or_get_tag")]
        public Tag CreateOrGetTag { get; set; }
        [JsonProperty("create_subitem")]
        public Item CreateSubitem { get; set; }
        [JsonProperty("create_update")]
        public Update CreateUpdate { get; set; }
        [JsonProperty("create_webhook")]
        public Webhook CreateWebhook { get; set; }
        [JsonProperty("create_workspace")]
        public Workspace CreateWorkspace { get; set; }
        [JsonProperty("delete_board")]
        public Board DeleteBoard { get; set; }
        [JsonProperty("delete_column")]
        public Column DeleteColumn { get; set; }
        [JsonProperty("delete_doc_block")]
        public DocumentBlockIDOnly DeleteDocBlock { get; set; }
        [JsonProperty("delete_folder")]
        public Folder DeleteFolder { get; set; }
        [JsonProperty("delete_group")]
        public Group DeleteGroup { get; set; }
        [JsonProperty("delete_item")]
        public Item DeleteItem { get; set; }
        [JsonProperty("delete_subscribers_from_board")]
        public ICollection<User> DeleteSubscribersFromBoard { get; set; }
        [JsonProperty("delete_teams_from_workspace")]
        public ICollection<Team> DeleteTeamsFromWorkspace { get; set; }
        [JsonProperty("delete_update")]
        public Update DeleteUpdate { get; set; }
        [JsonProperty("delete_users_from_workspace")]
        public ICollection<User> DeleteUsersFromWorkspace { get; set; }
        [JsonProperty("delete_webhook")]
        public Webhook DeleteWebhook { get; set; }
        [JsonProperty("delete_workspace")]
        public Workspace DeleteWorkspace { get; set; }
        [JsonProperty("duplicate_board")]
        public BoardDuplication DuplicateBoard { get; set; }
        [JsonProperty("duplicate_group")]
        public Group DuplicateGroup { get; set; }
        [JsonProperty("duplicate_item")]
        public Item DuplicateItem { get; set; }
        [JsonProperty("like_update")]
        public Update LikeUpdate { get; set; }
        [JsonProperty("move_item_to_board")]
        public Item MoveItemToBoard { get; set; }
        [JsonProperty("move_item_to_group")]
        public Item MoveItemToGroup { get; set; }
        [JsonProperty("remove_mock_app_subscription")]
        public AppSubscription RemoveMockAppSubscription { get; set; }
        [JsonProperty("set_mock_app_subscription")]
        public AppSubscription SetMockAppSubscription { get; set; }
        [JsonProperty("update_board")]
        public object UpdateBoard { get; set; }
        [JsonProperty("update_doc_block")]
        public DocumentBlock UpdateDocBlock { get; set; }
        [JsonProperty("update_folder")]
        public Folder UpdateFolder { get; set; }
        [JsonProperty("update_group")]
        public Group UpdateGroup { get; set; }
    }
}
