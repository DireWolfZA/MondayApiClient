using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Query {
        [JsonProperty("audit_logs")]
        public AuditLogPage? AuditLogs { get; set; }
        [JsonProperty("audit_event_catalogue")]
        public ICollection<AuditEventCatalogueEntry>? AuditEventCatalogue { get; set; }
        public ICollection<Connection>? Connections { get; set; }
        [JsonProperty("user_connections")]
        public ICollection<Connection>? UserConnections { get; set; }
        [JsonProperty("account_connections")]
        public ICollection<Connection>? AccountConnections { get; set; }
        public Connection? Connection { get; set; }
        [JsonProperty("connection_board_ids")]
        public ICollection<int>? ConnectionBoardIds { get; set; }
        [JsonProperty("trigger_events")]
        public TriggerEventsPage? TriggerEvents { get; set; }
        [JsonProperty("trigger_event")]
        public TriggerEvent? TriggerEvent { get; set; }
        [JsonProperty("block_events")]
        public BlockEventsPage? BlockEvents { get; set; }
        [JsonProperty("tool_events")]
        public ToolEventsPage? ToolEvents { get; set; }
        [JsonProperty("account_trigger_statistics")]
        public AccountTriggerStatistics? AccountTriggerStatistics { get; set; }
        [JsonProperty("account_triggers_statistics_by_entity_id")]
        public AccountTriggersByEntityID? AccountTriggersStatisticsByEntityID { get; set; }
        public string? Empty { get; set; }
        [JsonProperty("get_view_schema_by_type")]
        public object? GetViewSchemaByType { get; set; }
        public ICollection<Update>? Updates { get; set; }
        public ICollection<Reply>? Replies { get; set; }
        [JsonProperty("custom_activity")]
        public ICollection<CustomActivity>? CustomActivity { get; set; }
        [JsonProperty("timeline_item")]
        public TimelineItem? TimelineItem { get; set; }
        public TimelineResponse? Timeline { get; set; }
        [JsonProperty("managed_column")]
        public ICollection<ManagedColumn>? ManagedColumn { get; set; }
        [JsonProperty("get_column_type_schema")]
        public object? GetColumnTypeSchema { get; set; }
        public Validations? Validations { get; set; }
        public ICollection<Department>? Departments { get; set; }
        [JsonProperty("export_graph")]
        public BoardGraphExport? ExportGraph { get; set; }
        [JsonProperty("dependency_column_config")]
        public DependencyColumnConfigResult? DependencyColumnConfig { get; set; }
        [JsonProperty("export_events")]
        public EventsExport? ExportEvents { get; set; }
        [JsonProperty("article_blocks")]
        public ICollection<ArticleBlock?>? ArticleBlocks { get; set; }
        public ICollection<Article?>? Articles { get; set; }
        [JsonProperty("doc_version_diff")]
        public DocVersionDiff? DocVersionDiff { get; set; }
        [JsonProperty("doc_version_history")]
        public DocVersionHistory? DocVersionHistory { get; set; }
        [JsonProperty("export_markdown_from_doc")]
        public ExportMarkdownResult? ExportMarkdownFromDoc { get; set; }
        [JsonProperty("knowledge_base_search")]
        public KnowledgeBaseAnswer? KnowledgeBaseSearch { get; set; }
        public ICollection<GraphQLHierarchyObjectItem>? Favorites { get; set; }
        [JsonProperty("marketplace_app_discounts")]
        public ICollection<MarketplaceAppDiscount>? MarketplaceAppDiscounts { get; set; }
        [JsonProperty("app_subscriptions")]
        public AppSubscriptions? AppSubscriptions { get; set; }
        [JsonProperty("marketplace_vector_search")]
        public MarketplaceSearchResults? MarketplaceVectorSearch { get; set; }
        [JsonProperty("marketplace_fulltext_search")]
        public MarketplaceSearchResults? MarketplaceFulltextSearch { get; set; }
        [JsonProperty("marketplace_hybrid_search")]
        public MarketplaceSearchResults? MarketplaceHybridSearch { get; set; }
        [JsonProperty("marketplace_ai_search")]
        public MarketplaceAISearchResults? MarketplaceAiSearch { get; set; }
        public AppType? App { get; set; }
        [JsonProperty("ask_developer_docs")]
        public AppDocumentationAIResponse? AskDeveloperDocs { get; set; }
        [JsonProperty("get_app_lifecycle_subscriptions")]
        public ICollection<LifecycleSubscriptionKind>? GetAppLifecycleSubscriptions { get; set; }
        public Account? Account { get; set; }
        [JsonProperty("app_installs")]
        public ICollection<AppInstall?>? AppInstalls { get; set; }
        [JsonProperty("app_subscription")]
        public ICollection<AppSubscription?>? AppSubscription { get; set; }
        [JsonProperty("app_subscription_operations")]
        public AppSubscriptionOperationsCounter? AppSubscriptionOperations { get; set; }
        [JsonProperty("apps_monetization_info")]
        public AppsMonetizationInfo? AppsMonetizationInfo { get; set; }
        [JsonProperty("apps_monetization_status")]
        public AppMonetizationStatus? AppsMonetizationStatus { get; set; }
        public ICollection<Asset?>? Assets { get; set; }
        public ICollection<Board?>? Boards { get; set; }
        public Complexity? Complexity { get; set; }
        public ICollection<Document?>? Docs { get; set; }
        public ICollection<Folder?>? Folders { get; set; }
        public ICollection<Item?>? Items { get; set; }
        [JsonProperty("items_page_by_column_values")]
        public ItemsResponse? ItemsPageByColumnValues { get; set; }
        public User? Me { get; set; }
        [JsonProperty("next_items_page")]
        public ItemsResponse? NextItemsPage { get; set; }
        public ICollection<Tag?>? Tags { get; set; }
        public ICollection<Team?>? Teams { get; set; }
        public ICollection<User?>? Users { get; set; }
        public ICollection<Webhook?>? Webhooks { get; set; }
        public ICollection<Workspace?>? Workspaces { get; set; }
        [JsonProperty("board_candidates")]
        public ICollection<Board>? BoardCandidates { get; set; }
        public NotetakerQueries? Notetaker { get; set; }
        public ICollection<NotificationV2>? Notifications { get; set; }
        [JsonProperty("notifications_settings")]
        public ICollection<NotificationSetting>? NotificationsSettings { get; set; }
        [JsonProperty("mute_board_settings")]
        public ICollection<BoardMuteSettings>? MuteBoardSettings { get; set; }
        [JsonProperty("object_types_unique_keys")]
        public ICollection<ObjectTypeUniqueKeyData>? ObjectTypesUniqueKeys { get; set; }
        public ICollection<Object>? Objects { get; set; }
        [JsonProperty("object_relations")]
        public ICollection<ObjectRelation>? ObjectRelations { get; set; }
        public Version? Version { get; set; }
        public ICollection<Version>? Versions { get; set; }
        [JsonProperty("platform_api")]
        public PlatformAPI? PlatformAPI { get; set; }
        public AggregateQueryResult? Aggregate { get; set; }
        [JsonProperty("get_directory_resources")]
        public DirectoryResourcesResponse? GetDirectoryResources { get; set; }
        [JsonProperty("allowed_sequences_to_enroll")]
        public ICollection<Sequence>? AllowedSequencesToEnroll { get; set; }
        public ICollection<Sprint>? Sprints { get; set; }
        [JsonProperty("account_roles")]
        public ICollection<AccountRole>? AccountRoles { get; set; }
        [JsonProperty("all_widgets_schema")]
        public ICollection<WidgetSchemaInfo>? AllWidgetsSchema { get; set; }
        public ResponseForm? Form { get; set; }
    }
}
