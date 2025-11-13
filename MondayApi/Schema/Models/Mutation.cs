using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Mutation {
        [JsonProperty("create_view_table")]
        public BoardView? CreateViewTable { get; set; }
        [JsonProperty("create_view")]
        public BoardView? CreateView { get; set; }
        [JsonProperty("update_view_table")]
        public BoardView? UpdateViewTable { get; set; }
        [JsonProperty("update_view")]
        public BoardView? UpdateView { get; set; }
        [JsonProperty("delete_view")]
        public BoardView? DeleteView { get; set; }
        [JsonProperty("like_update")]
        public Update? LikeUpdate { get; set; }
        [JsonProperty("unlike_update")]
        public Update? UnlikeUpdate { get; set; }
        [JsonProperty("delete_update")]
        public Update? DeleteUpdate { get; set; }
        [JsonProperty("edit_update")]
        public Update? EditUpdate { get; set; }
        [JsonProperty("pin_to_top")]
        public Update? PinToTop { get; set; }
        [JsonProperty("unpin_from_top")]
        public Update? UnpinFromTop { get; set; }
        [JsonProperty("create_update")]
        public Update? CreateUpdate { get; set; }
        [JsonProperty("create_timeline_item")]
        public TimelineItem? CreateTimelineItem { get; set; }
        [JsonProperty("delete_timeline_item")]
        public TimelineItem? DeleteTimelineItem { get; set; }
        [JsonProperty("create_custom_activity")]
        public CustomActivity? CreateCustomActivity { get; set; }
        [JsonProperty("delete_custom_activity")]
        public CustomActivity? DeleteCustomActivity { get; set; }
        [JsonProperty("create_dropdown_managed_column")]
        public DropdownManagedColumn? CreateDropdownManagedColumn { get; set; }
        [JsonProperty("create_status_managed_column")]
        public StatusManagedColumn? CreateStatusManagedColumn { get; set; }
        [JsonProperty("update_dropdown_managed_column")]
        public DropdownManagedColumn? UpdateDropdownManagedColumn { get; set; }
        [JsonProperty("update_status_managed_column")]
        public StatusManagedColumn? UpdateStatusManagedColumn { get; set; }
        [JsonProperty("activate_managed_column")]
        public ManagedColumn? ActivateManagedColumn { get; set; }
        [JsonProperty("deactivate_managed_column")]
        public ManagedColumn? DeactivateManagedColumn { get; set; }
        [JsonProperty("delete_managed_column")]
        public ManagedColumn? DeleteManagedColumn { get; set; }
        [JsonProperty("update_status_column")]
        public Column? UpdateStatusColumn { get; set; }
        [JsonProperty("update_dropdown_column")]
        public Column? UpdateDropdownColumn { get; set; }
        [JsonProperty("update_column")]
        public Column? UpdateColumn { get; set; }
        [JsonProperty("delete_column")]
        public Column? DeleteColumn { get; set; }
        [JsonProperty("create_status_column")]
        public Column? CreateStatusColumn { get; set; }
        [JsonProperty("create_dropdown_column")]
        public Column? CreateDropdownColumn { get; set; }
        [JsonProperty("create_column")]
        public Column? CreateColumn { get; set; }
        [JsonProperty("add_required_column")]
        public RequiredColumns? AddRequiredColumn { get; set; }
        [JsonProperty("remove_required_column")]
        public RequiredColumns? RemoveRequiredColumn { get; set; }
        [JsonProperty("update_dependency_column")]
        public object? UpdateDependencyColumn { get; set; }
        [JsonProperty("add_content_to_doc_from_markdown")]
        public DocBlocksFromMarkdownResult? AddContentToDocFromMarkdown { get; set; }
        [JsonProperty("delete_doc")]
        public object? DeleteDoc { get; set; }
        [JsonProperty("duplicate_doc")]
        public object? DuplicateDoc { get; set; }
        [JsonProperty("import_doc_from_html")]
        public ImportDocFromHtmlResult? ImportDocFromHtml { get; set; }
        [JsonProperty("update_article_block")]
        public ArticleBlock? UpdateArticleBlock { get; set; }
        [JsonProperty("update_doc_name")]
        public object? UpdateDocName { get; set; }
        [JsonProperty("create_favorite")]
        public CreateFavoriteResultType? CreateFavorite { get; set; }
        [JsonProperty("delete_favorite")]
        public DeleteFavoriteInputResultType? DeleteFavorite { get; set; }
        [JsonProperty("update_favorite_position")]
        public UpdateFavoriteResultType? UpdateFavoritePosition { get; set; }
        [JsonProperty("grant_marketplace_app_discount")]
        public GrantMarketplaceAppDiscountResult? GrantMarketplaceAppDiscount { get; set; }
        [JsonProperty("delete_marketplace_app_discount")]
        public DeleteMarketplaceAppDiscountResult? DeleteMarketplaceAppDiscount { get; set; }
        [JsonProperty("create_app")]
        public CreateAppResponse? CreateApp { get; set; }
        [JsonProperty("update_app")]
        public AppType? UpdateApp { get; set; }
        [JsonProperty("update_app_feature")]
        public AppFeatureType? UpdateAppFeature { get; set; }
        [JsonProperty("create_app_feature")]
        public AppFeatureType? CreateAppFeature { get; set; }
        [JsonProperty("add_file_to_column")]
        public Asset? AddFileToColumn { get; set; }
        [JsonProperty("add_file_to_update")]
        public Asset? AddFileToUpdate { get; set; }
        [JsonProperty("add_teams_to_board")]
        public ICollection<Team?>? AddTeamsToBoard { get; set; }
        [JsonProperty("add_teams_to_workspace")]
        public ICollection<Team?>? AddTeamsToWorkspace { get; set; }
        [JsonProperty("add_users_to_board")]
        public ICollection<User?>? AddUsersToBoard { get; set; }
        [JsonProperty("add_users_to_team")]
        public ChangeTeamMembershipsResult? AddUsersToTeam { get; set; }
        [JsonProperty("add_users_to_workspace")]
        public ICollection<User?>? AddUsersToWorkspace { get; set; }
        [JsonProperty("archive_board")]
        public Board? ArchiveBoard { get; set; }
        [JsonProperty("archive_group")]
        public Group? ArchiveGroup { get; set; }
        [JsonProperty("archive_item")]
        public Item? ArchiveItem { get; set; }
        [JsonProperty("batch_extend_trial_period")]
        public BatchExtendTrialPeriod? BatchExtendTrialPeriod { get; set; }
        [JsonProperty("change_column_metadata")]
        public Column? ChangeColumnMetadata { get; set; }
        [JsonProperty("change_column_title")]
        public Column? ChangeColumnTitle { get; set; }
        [JsonProperty("change_column_value")]
        public Item? ChangeColumnValue { get; set; }
        [JsonProperty("change_item_position")]
        public Item? ChangeItemPosition { get; set; }
        [JsonProperty("change_multiple_column_values")]
        public Item? ChangeMultipleColumnValues { get; set; }
        [JsonProperty("change_simple_column_value")]
        public Item? ChangeSimpleColumnValue { get; set; }
        [JsonProperty("clear_item_updates")]
        public Item? ClearItemUpdates { get; set; }
        public Complexity? Complexity { get; set; }
        [JsonProperty("create_board")]
        public Board? CreateBoard { get; set; }
        [JsonProperty("create_doc")]
        public Document? CreateDoc { get; set; }
        [JsonProperty("create_doc_block")]
        public DocumentBlock? CreateDocBlock { get; set; }
        [JsonProperty("create_folder")]
        public Folder? CreateFolder { get; set; }
        [JsonProperty("create_group")]
        public Group? CreateGroup { get; set; }
        [JsonProperty("create_item")]
        public Item? CreateItem { get; set; }
        [JsonProperty("create_notification")]
        public Notification? CreateNotification { get; set; }
        [JsonProperty("create_or_get_tag")]
        public Tag? CreateOrGetTag { get; set; }
        [JsonProperty("create_subitem")]
        public Item? CreateSubitem { get; set; }
        [JsonProperty("create_webhook")]
        public Webhook? CreateWebhook { get; set; }
        [JsonProperty("create_workspace")]
        public Workspace? CreateWorkspace { get; set; }
        [JsonProperty("delete_board")]
        public Board? DeleteBoard { get; set; }
        [JsonProperty("delete_doc_block")]
        public DocumentBlockIDOnly? DeleteDocBlock { get; set; }
        [JsonProperty("delete_folder")]
        public Folder? DeleteFolder { get; set; }
        [JsonProperty("delete_group")]
        public Group? DeleteGroup { get; set; }
        [JsonProperty("delete_item")]
        public Item? DeleteItem { get; set; }
        [JsonProperty("delete_subscribers_from_board")]
        public ICollection<User?>? DeleteSubscribersFromBoard { get; set; }
        [JsonProperty("delete_teams_from_board")]
        public ICollection<Team?>? DeleteTeamsFromBoard { get; set; }
        [JsonProperty("delete_teams_from_workspace")]
        public ICollection<Team?>? DeleteTeamsFromWorkspace { get; set; }
        [JsonProperty("delete_users_from_workspace")]
        public ICollection<User?>? DeleteUsersFromWorkspace { get; set; }
        [JsonProperty("delete_webhook")]
        public Webhook? DeleteWebhook { get; set; }
        [JsonProperty("delete_workspace")]
        public Workspace? DeleteWorkspace { get; set; }
        [JsonProperty("duplicate_board")]
        public BoardDuplication? DuplicateBoard { get; set; }
        [JsonProperty("duplicate_group")]
        public Group? DuplicateGroup { get; set; }
        [JsonProperty("duplicate_item")]
        public Item? DuplicateItem { get; set; }
        [JsonProperty("increase_app_subscription_operations")]
        public AppSubscriptionOperationsCounter? IncreaseAppSubscriptionOperations { get; set; }
        [JsonProperty("move_item_to_board")]
        public Item? MoveItemToBoard { get; set; }
        [JsonProperty("move_item_to_group")]
        public Item? MoveItemToGroup { get; set; }
        [JsonProperty("remove_mock_app_subscription")]
        public AppSubscription? RemoveMockAppSubscription { get; set; }
        [JsonProperty("remove_users_from_team")]
        public ChangeTeamMembershipsResult? RemoveUsersFromTeam { get; set; }
        [JsonProperty("set_board_permission")]
        public SetBoardPermissionResponse? SetBoardPermission { get; set; }
        [JsonProperty("set_mock_app_subscription")]
        public AppSubscription? SetMockAppSubscription { get; set; }
        [JsonProperty("update_assets_on_item")]
        public Item? UpdateAssetsOnItem { get; set; }
        [JsonProperty("update_board")]
        public string? UpdateBoard { get; set; }
        [JsonProperty("update_board_hierarchy")]
        public UpdateBoardHierarchyResult? UpdateBoardHierarchy { get; set; }
        [JsonProperty("update_doc_block")]
        public DocumentBlock? UpdateDocBlock { get; set; }
        [JsonProperty("update_folder")]
        public Folder? UpdateFolder { get; set; }
        [JsonProperty("update_group")]
        public Group? UpdateGroup { get; set; }
        [JsonProperty("update_overview_hierarchy")]
        public UpdateOverviewHierarchy? UpdateOverviewHierarchy { get; set; }
        [JsonProperty("update_workspace")]
        public Workspace? UpdateWorkspace { get; set; }
        [JsonProperty("use_template")]
        public Template? UseTemplate { get; set; }
        [JsonProperty("convert_board_to_project")]
        public ConvertBoardToProjectResult? ConvertBoardToProject { get; set; }
        [JsonProperty("update_notification_setting")]
        public ICollection<NotificationSetting>? UpdateNotificationSetting { get; set; }
        [JsonProperty("update_mute_board_settings")]
        public ICollection<BoardMuteSettings>? UpdateMuteBoardSettings { get; set; }
        [JsonProperty("create_object")]
        public Object? CreateObject { get; set; }
        [JsonProperty("delete_object")]
        public Object? DeleteObject { get; set; }
        [JsonProperty("archive_object")]
        public Object? ArchiveObject { get; set; }
        [JsonProperty("add_subscribers_to_object")]
        public Object? AddSubscribersToObject { get; set; }
        [JsonProperty("update_object")]
        public Object? UpdateObject { get; set; }
        [JsonProperty("publish_object")]
        public ObjectOperationResponse? PublishObject { get; set; }
        [JsonProperty("unpublish_object")]
        public ObjectOperationResponse? UnpublishObject { get; set; }
        [JsonProperty("connect_project_to_portfolio")]
        public ConnectProjectResult? ConnectProjectToPortfolio { get; set; }
        [JsonProperty("create_portfolio")]
        public CreatePortfolioResult? CreatePortfolio { get; set; }
        [JsonProperty("create_team")]
        public Team? CreateTeam { get; set; }
        [JsonProperty("activate_users")]
        public ActivateUsersResult? ActivateUsers { get; set; }
        [JsonProperty("deactivate_users")]
        public DeactivateUsersResult? DeactivateUsers { get; set; }
        [JsonProperty("delete_team")]
        public Team? DeleteTeam { get; set; }
        [JsonProperty("update_users_role")]
        public UpdateUsersRoleResult? UpdateUsersRole { get; set; }
        [JsonProperty("assign_team_owners")]
        public AssignTeamOwnersResult? AssignTeamOwners { get; set; }
        [JsonProperty("remove_team_owners")]
        public RemoveTeamOwnersResult? RemoveTeamOwners { get; set; }
        [JsonProperty("update_email_domain")]
        public UpdateEmailDomainResult? UpdateEmailDomain { get; set; }
        [JsonProperty("update_multiple_users")]
        public UpdateUserAttributesResult? UpdateMultipleUsers { get; set; }
        [JsonProperty("invite_users")]
        public InviteUsersResult? InviteUsers { get; set; }
        [JsonProperty("create_widget")]
        public Widget? CreateWidget { get; set; }
        [JsonProperty("delete_widget")]
        public bool? DeleteWidget { get; set; }
        [JsonProperty("create_dashboard")]
        public Dashboard? CreateDashboard { get; set; }
        [JsonProperty("update_dashboard")]
        public Dashboard? UpdateDashboard { get; set; }
        [JsonProperty("delete_dashboard")]
        public bool? DeleteDashboard { get; set; }
        [JsonProperty("update_form")]
        public ResponseForm? UpdateForm { get; set; }
        [JsonProperty("update_form_settings")]
        public ResponseForm? UpdateFormSettings { get; set; }
        [JsonProperty("create_form_question")]
        public FormQuestion? CreateFormQuestion { get; set; }
        [JsonProperty("update_form_question")]
        public FormQuestion? UpdateFormQuestion { get; set; }
        [JsonProperty("delete_question")]
        public bool? DeleteQuestion { get; set; }
        [JsonProperty("activate_form")]
        public bool? ActivateForm { get; set; }
        [JsonProperty("deactivate_form")]
        public bool? DeactivateForm { get; set; }
        [JsonProperty("shorten_form_url")]
        public FormShortenedLink? ShortenFormURL { get; set; }
        [JsonProperty("create_form_tag")]
        public FormTag? CreateFormTag { get; set; }
        [JsonProperty("update_form_tag")]
        public bool? UpdateFormTag { get; set; }
        [JsonProperty("delete_form_tag")]
        public bool? DeleteFormTag { get; set; }
        [JsonProperty("create_form")]
        public DehydratedFormResponse? CreateForm { get; set; }
        [JsonProperty("set_form_password")]
        public ResponseForm? SetFormPassword { get; set; }
    }
}
