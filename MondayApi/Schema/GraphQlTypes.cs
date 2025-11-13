using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public static class GraphQlTypes {
        public const string Boolean = "Boolean";
        public const string CompareValue = "CompareValue";
        public const string Date = "Date";
        public const string File = "File";
        public const string Float = "Float";
        public const string ID = "ID";
        public const string Int = "Int";
        public const string Iso8601DateTime = "ISO8601DateTime";
        public const string Json = "JSON";
        public const string PolicyPolicy = "policy__Policy";
        public const string String = "String";

        public const string ActivateUsersErrorCode = "ActivateUsersErrorCode";
        public const string AggregateFromElementType = "AggregateFromElementType";
        public const string AggregateSelectElementType = "AggregateSelectElementType";
        public const string AggregateSelectFunctionName = "AggregateSelectFunctionName";
        public const string AppFeatureReleaseKind = "AppFeatureReleaseKind";
        public const string AppFeatureTypeE = "AppFeatureTypeE";
        public const string AppKind = "AppKind";
        public const string AppStatus = "AppStatus";
        public const string AssetsSource = "AssetsSource";
        public const string AssignTeamOwnersErrorCode = "AssignTeamOwnersErrorCode";
        public const string BaseRoleName = "BaseRoleName";
        public const string BoardAccessLevel = "BoardAccessLevel";
        public const string BoardAttributes = "BoardAttributes";
        public const string BoardBasicRoleName = "BoardBasicRoleName";
        public const string BoardEditPermissions = "BoardEditPermissions";
        public const string BoardHierarchy = "BoardHierarchy";
        public const string BoardKind = "BoardKind";
        public const string BoardMuteState = "BoardMuteState";
        public const string BoardObjectType = "BoardObjectType";
        public const string BoardsOrderBy = "BoardsOrderBy";
        public const string BoardSubscriberKind = "BoardSubscriberKind";
        public const string BoardUsage = "BoardUsage";
        public const string BoardViewAccessLevel = "BoardViewAccessLevel";
        public const string CalculatedFunction = "CalculatedFunction";
        public const string ChannelEditableStatus = "ChannelEditableStatus";
        public const string ChannelType = "ChannelType";
        public const string ColumnCapability = "ColumnCapability";
        public const string ColumnProperty = "ColumnProperty";
        public const string ColumnType = "ColumnType";
        public const string CustomActivityColor = "CustomActivityColor";
        public const string CustomActivityIcon = "CustomActivityIcon";
        public const string CustomizableBoardSettings = "CustomizableBoardSettings";
        public const string DashboardKind = "DashboardKind";
        public const string DeactivateUsersErrorCode = "DeactivateUsersErrorCode";
        public const string DependencyRelation = "DependencyRelation";
        public const string DiscountPeriod = "DiscountPeriod";
        public const string DocBlockContentType = "DocBlockContentType";
        public const string DocKind = "DocKind";
        public const string DocsOrderBy = "DocsOrderBy";
        public const string DuplicateBoardType = "DuplicateBoardType";
        public const string DuplicateType = "DuplicateType";
        public const string ExternalWidget = "ExternalWidget";
        public const string FileColumnValue = "FileColumnValue";
        public const string FileLinkValueKind = "FileLinkValueKind";
        public const string FirstDayOfTheWeek = "FirstDayOfTheWeek";
        public const string FolderColor = "FolderColor";
        public const string FolderCustomIcon = "FolderCustomIcon";
        public const string FolderFontWeight = "FolderFontWeight";
        public const string FormAlignment = "FormAlignment";
        public const string FormBackgrounds = "FormBackgrounds";
        public const string FormDirection = "FormDirection";
        public const string FormFontSize = "FormFontSize";
        public const string FormFormat = "FormFormat";
        public const string FormLogoPosition = "FormLogoPosition";
        public const string FormLogoSize = "FormLogoSize";
        public const string FormQuestionPrefillSources = "FormQuestionPrefillSources";
        public const string FormQuestionSelectDisplay = "FormQuestionSelectDisplay";
        public const string FormQuestionSelectOrderByOptions = "FormQuestionSelectOrderByOptions";
        public const string FormQuestionType = "FormQuestionType";
        public const string GraphQLMondayObject = "GraphqlMondayObject";
        public const string GroupAttributes = "GroupAttributes";
        public const string InviteUsersErrorCode = "InviteUsersErrorCode";
        public const string ItemsOrderByDirection = "ItemsOrderByDirection";
        public const string ItemsQueryOperator = "ItemsQueryOperator";
        public const string ItemsQueryRuleOperator = "ItemsQueryRuleOperator";
        public const string Kind = "Kind";
        public const string ManagedColumnState = "ManagedColumnState";
        public const string ManagedColumnTypes = "ManagedColumnTypes";
        public const string MentionType = "MentionType";
        public const string NotificationTargetType = "NotificationTargetType";
        public const string NumberValueUnitDirection = "NumberValueUnitDirection";
        public const string ObjectState = "ObjectState";
        public const string ObjectType = "ObjectType";
        public const string OrderBy = "OrderBy";
        public const string PositionRelative = "PositionRelative";
        public const string PrivacyKind = "PrivacyKind";
        public const string Product = "Product";
        public const string RemoveTeamOwnersErrorCode = "RemoveTeamOwnersErrorCode";
        public const string ScopeType = "ScopeType";
        public const string SortDirection = "SortDirection";
        public const string SprintSnapshotKind = "SprintSnapshotKind";
        public const string SprintState = "SprintState";
        public const string State = "State";
        public const string StatusCalculatedFunction = "StatusCalculatedFunction";
        public const string StatusColumnColors = "StatusColumnColors";
        public const string SubscriberKind = "SubscriberKind";
        public const string SubscriptionDiscountModelType = "SubscriptionDiscountModelType";
        public const string SubscriptionDiscountType = "SubscriptionDiscountType";
        public const string SubscriptionPeriodType = "SubscriptionPeriodType";
        public const string SubscriptionStatus = "SubscriptionStatus";
        public const string UpdateEmailDomainErrorCode = "UpdateEmailDomainErrorCode";
        public const string UpdateUserAttributesErrorCode = "UpdateUserAttributesErrorCode";
        public const string UpdateUsersRoleErrorCode = "UpdateUsersRoleErrorCode";
        public const string UserKind = "UserKind";
        public const string UserRole = "UserRole";
        public const string ValidationsEntityType = "ValidationsEntityType";
        public const string VersionKind = "VersionKind";
        public const string ViewKind = "ViewKind";
        public const string ViewMutationKind = "ViewMutationKind";
        public const string WebhookEventType = "WebhookEventType";
        public const string WidgetParentKind = "WidgetParentKind";
        public const string WorkspaceKind = "WorkspaceKind";
        public const string WorkspacesOrderBy = "WorkspacesOrderBy";
        public const string WorkspaceSubscriberKind = "WorkspaceSubscriberKind";

        public const string Account = "Account";
        public const string AccountProduct = "AccountProduct";
        public const string AccountRole = "AccountRole";
        public const string ActivateUsersError = "ActivateUsersError";
        public const string ActivateUsersResult = "ActivateUsersResult";
        public const string ActivityLogType = "ActivityLogType";
        public const string AggregateBasicAggregationResult = "AggregateBasicAggregationResult";
        public const string AggregateGroupByResult = "AggregateGroupByResult";
        public const string AggregateQueryResult = "AggregateQueryResult";
        public const string AggregateResultEntry = "AggregateResultEntry";
        public const string AggregateResultSet = "AggregateResultSet";
        public const string AppFeatureType = "AppFeatureType";
        public const string AppInstall = "AppInstall";
        public const string AppInstallAccount = "AppInstallAccount";
        public const string AppInstallPermissions = "AppInstallPermissions";
        public const string AppInstallUser = "AppInstallUser";
        public const string AppMonetizationStatus = "AppMonetizationStatus";
        public const string AppsMonetizationInfo = "AppsMonetizationInfo";
        public const string AppSubscription = "AppSubscription";
        public const string AppSubscriptionDetails = "AppSubscriptionDetails";
        public const string AppSubscriptionOperationsCounter = "AppSubscriptionOperationsCounter";
        public const string AppSubscriptions = "AppSubscriptions";
        public const string AppType = "AppType";
        public const string AppVersion = "AppVersion";
        public const string ArticleBlock = "ArticleBlock";
        public const string Asset = "Asset";
        public const string AssignTeamOwnersError = "AssignTeamOwnersError";
        public const string AssignTeamOwnersResult = "AssignTeamOwnersResult";
        public const string AuditEventCatalogueEntry = "AuditEventCatalogueEntry";
        public const string AuditLogEntry = "AuditLogEntry";
        public const string AuditLogPage = "AuditLogPage";
        public const string BatchExtendTrialPeriod = "BatchExtendTrialPeriod";
        public const string BatteryValue = "BatteryValue";
        public const string BatteryValueItem = "BatteryValueItem";
        public const string BlockEvent = "BlockEvent";
        public const string BlockEventsPage = "BlockEventsPage";
        public const string Board = "Board";
        public const string BoardDuplication = "BoardDuplication";
        public const string BoardGraphExport = "BoardGraphExport";
        public const string BoardMuteSettings = "BoardMuteSettings";
        public const string BoardRelationValue = "BoardRelationValue";
        public const string BoardView = "BoardView";
        public const string ButtonValue = "ButtonValue";
        public const string CalculatedCapability = "CalculatedCapability";
        public const string ChangeTeamMembershipsResult = "ChangeTeamMembershipsResult";
        public const string CheckboxValue = "CheckboxValue";
        public const string ColorPickerValue = "ColorPickerValue";
        public const string Column = "Column";
        public const string ColumnCapabilities = "ColumnCapabilities";
        public const string Complexity = "Complexity";
        public const string Connection = "Connection";
        public const string ConnectProjectResult = "ConnectProjectResult";
        public const string ConvertBoardToProjectResult = "ConvertBoardToProjectResult";
        public const string Country = "Country";
        public const string CountryValue = "CountryValue";
        public const string CreateAppResponse = "CreateAppResponse";
        public const string CreateFavoriteResultType = "CreateFavoriteResultType";
        public const string CreatePortfolioResult = "CreatePortfolioResult";
        public const string CreationLogValue = "CreationLogValue";
        public const string CustomActivity = "CustomActivity";
        public const string CustomFieldMetas = "CustomFieldMetas";
        public const string CustomFieldValue = "CustomFieldValue";
        public const string DailyAnalytics = "DailyAnalytics";
        public const string DailyLimit = "DailyLimit";
        public const string Dashboard = "Dashboard";
        public const string DateValue = "DateValue";
        public const string DeactivateUsersError = "DeactivateUsersError";
        public const string DeactivateUsersResult = "DeactivateUsersResult";
        public const string DehydratedFormResponse = "DehydratedFormResponse";
        public const string DeleteFavoriteInputResultType = "DeleteFavoriteInputResultType";
        public const string DeleteMarketplaceAppDiscount = "DeleteMarketplaceAppDiscount";
        public const string DeleteMarketplaceAppDiscountResult = "DeleteMarketplaceAppDiscountResult";
        public const string DependencyValue = "DependencyValue";
        public const string DirectDocValue = "DirectDocValue";
        public const string DocBlocksFromMarkdownResult = "DocBlocksFromMarkdownResult";
        public const string Document = "Document";
        public const string DocumentBlock = "DocumentBlock";
        public const string DocumentBlockIDOnly = "DocumentBlockIdOnly";
        public const string DocValue = "DocValue";
        public const string DropdownColumnSettings = "DropdownColumnSettings";
        public const string DropdownLabel = "DropdownLabel";
        public const string DropdownManagedColumn = "DropdownManagedColumn";
        public const string DropdownValue = "DropdownValue";
        public const string DropdownValueOption = "DropdownValueOption";
        public const string EmailValue = "EmailValue";
        public const string ExportMarkdownResult = "ExportMarkdownResult";
        public const string ExtendTrialPeriod = "ExtendTrialPeriod";
        public const string FileAssetValue = "FileAssetValue";
        public const string FileDocValue = "FileDocValue";
        public const string FileLinkValue = "FileLinkValue";
        public const string FileValue = "FileValue";
        public const string Folder = "Folder";
        public const string FormAccessibility = "FormAccessibility";
        public const string FormAfterSubmissionView = "FormAfterSubmissionView";
        public const string FormAppearance = "FormAppearance";
        public const string FormBackground = "FormBackground";
        public const string FormCloseDate = "FormCloseDate";
        public const string FormDraftSubmission = "FormDraftSubmission";
        public const string FormFeatures = "FormFeatures";
        public const string FormLayout = "FormLayout";
        public const string FormLogo = "FormLogo";
        public const string FormMonday = "FormMonday";
        public const string FormPassword = "FormPassword";
        public const string FormPreSubmissionView = "FormPreSubmissionView";
        public const string FormQuestion = "FormQuestion";
        public const string FormQuestionOption = "FormQuestionOption";
        public const string FormQuestionSettings = "FormQuestionSettings";
        public const string FormRedirectAfterSubmission = "FormRedirectAfterSubmission";
        public const string FormRequireLogin = "FormRequireLogin";
        public const string FormResponseLimit = "FormResponseLimit";
        public const string FormShortenedLink = "FormShortenedLink";
        public const string FormStartButton = "FormStartButton";
        public const string FormSubmitButton = "FormSubmitButton";
        public const string FormTag = "FormTag";
        public const string FormText = "FormText";
        public const string FormulaValue = "FormulaValue";
        public const string GrantMarketplaceAppDiscount = "GrantMarketplaceAppDiscount";
        public const string GrantMarketplaceAppDiscountResult = "GrantMarketplaceAppDiscountResult";
        public const string GraphQLFolder = "GraphqlFolder";
        public const string GraphQLHierarchyObjectItem = "GraphqlHierarchyObjectItem";
        public const string Group = "Group";
        public const string GroupValue = "GroupValue";
        public const string HierarchyObjectID = "HierarchyObjectID";
        public const string HourValue = "HourValue";
        public const string ImportDocFromHTMLResult = "ImportDocFromHtmlResult";
        public const string IntegrationValue = "IntegrationValue";
        public const string InviteUsersError = "InviteUsersError";
        public const string InviteUsersResult = "InviteUsersResult";
        public const string Item = "Item";
        public const string ItemDescription = "ItemDescription";
        public const string ItemIDValue = "ItemIdValue";
        public const string ItemsResponse = "ItemsResponse";
        public const string LastUpdatedValue = "LastUpdatedValue";
        public const string Like = "Like";
        public const string LinkValue = "LinkValue";
        public const string LocationValue = "LocationValue";
        public const string LongTextValue = "LongTextValue";
        public const string ManagedColumn = "ManagedColumn";
        public const string MarketplaceAiSearchResult = "MarketplaceAiSearchResult";
        public const string MarketplaceAiSearchResults = "MarketplaceAiSearchResults";
        public const string MarketplaceAppDiscount = "MarketplaceAppDiscount";
        public const string MarketplaceAppMetadata = "MarketplaceAppMetadata";
        public const string MarketplaceSearchAppDocument = "MarketplaceSearchAppDocument";
        public const string MarketplaceSearchHit = "MarketplaceSearchHit";
        public const string MarketplaceSearchResults = "MarketplaceSearchResults";
        public const string MirroredItem = "MirroredItem";
        public const string MirrorValue = "MirrorValue";
        public const string Mutation = "Mutation";
        public const string Notification = "Notification";
        public const string NotificationSetting = "NotificationSetting";
        public const string NotificationSettingChannel = "NotificationSettingChannel";
        public const string NotificationV2 = "NotificationV2";
        public const string NumbersValue = "NumbersValue";
        public const string Object = "Object";
        public const string ObjectOperationResponse = "ObjectOperationResponse";
        public const string ObjectTypeUniqueKey = "ObjectTypeUniqueKey";
        public const string OutOfOffice = "OutOfOffice";
        public const string Overview = "Overview";
        public const string Pagination = "Pagination";
        public const string PeopleEntity = "PeopleEntity";
        public const string PeopleValue = "PeopleValue";
        public const string PersonValue = "PersonValue";
        public const string PhonePrefixPredefined = "PhonePrefixPredefined";
        public const string PhoneValue = "PhoneValue";
        public const string Plan = "Plan";
        public const string PlatformApi = "PlatformApi";
        public const string PlatformApiDailyAnalyticsByApp = "PlatformApiDailyAnalyticsByApp";
        public const string PlatformApiDailyAnalyticsByDay = "PlatformApiDailyAnalyticsByDay";
        public const string PlatformApiDailyAnalyticsByUser = "PlatformApiDailyAnalyticsByUser";
        public const string PrefillSettings = "PrefillSettings";
        public const string ProgressValue = "ProgressValue";
        public const string Query = "Query";
        public const string RatingValue = "RatingValue";
        public const string RemoveTeamOwnersError = "RemoveTeamOwnersError";
        public const string RemoveTeamOwnersResult = "RemoveTeamOwnersResult";
        public const string Reply = "Reply";
        public const string RequiredColumns = "RequiredColumns";
        public const string ResponseForm = "ResponseForm";
        public const string SetBoardPermissionResponse = "SetBoardPermissionResponse";
        public const string Sprint = "Sprint";
        public const string SprintSnapshot = "SprintSnapshot";
        public const string SprintSnapshotColumnMetadata = "SprintSnapshotColumnMetadata";
        public const string SprintSnapshotItem = "SprintSnapshotItem";
        public const string SprintSnapshotItemColumnValue = "SprintSnapshotItemColumnValue";
        public const string SprintTimeline = "SprintTimeline";
        public const string StatusColumnSettings = "StatusColumnSettings";
        public const string StatusLabel = "StatusLabel";
        public const string StatusLabelStyle = "StatusLabelStyle";
        public const string StatusManagedColumn = "StatusManagedColumn";
        public const string StatusValue = "StatusValue";
        public const string SubscriptionDiscount = "SubscriptionDiscount";
        public const string SubtasksValue = "SubtasksValue";
        public const string Tag = "Tag";
        public const string TagsValue = "TagsValue";
        public const string Team = "Team";
        public const string TeamValue = "TeamValue";
        public const string Template = "Template";
        public const string TextValue = "TextValue";
        public const string TimelineItem = "TimelineItem";
        public const string TimelineItemsPage = "TimelineItemsPage";
        public const string TimelineResponse = "TimelineResponse";
        public const string TimelineValue = "TimelineValue";
        public const string TimeTrackingHistoryItem = "TimeTrackingHistoryItem";
        public const string TimeTrackingValue = "TimeTrackingValue";
        public const string TriggerEvent = "TriggerEvent";
        public const string TriggerEventsPage = "TriggerEventsPage";
        public const string UnsupportedValue = "UnsupportedValue";
        public const string Update = "Update";
        public const string UpdateBoardHierarchyResult = "UpdateBoardHierarchyResult";
        public const string UpdateEmailDomainError = "UpdateEmailDomainError";
        public const string UpdateEmailDomainResult = "UpdateEmailDomainResult";
        public const string UpdateFavoriteResultType = "UpdateFavoriteResultType";
        public const string UpdateOverviewHierarchy = "UpdateOverviewHierarchy";
        public const string UpdatePin = "UpdatePin";
        public const string UpdateUserAttributesError = "UpdateUserAttributesError";
        public const string UpdateUserAttributesResult = "UpdateUserAttributesResult";
        public const string UpdateUsersRoleError = "UpdateUsersRoleError";
        public const string UpdateUsersRoleResult = "UpdateUsersRoleResult";
        public const string User = "User";
        public const string Validations = "Validations";
        public const string Version = "Version";
        public const string VoteValue = "VoteValue";
        public const string Watcher = "Watcher";
        public const string Webhook = "Webhook";
        public const string WeekValue = "WeekValue";
        public const string Widget = "Widget";
        public const string WidgetParentOutput = "WidgetParentOutput";
        public const string WidgetSchemaInfo = "WidgetSchemaInfo";
        public const string Workspace = "Workspace";
        public const string WorkspaceIcon = "WorkspaceIcon";
        public const string WorkspaceSettings = "WorkspaceSettings";
        public const string WorldClockValue = "WorldClockValue";

        public const string AggregateFromTableInput = "AggregateFromTableInput";
        public const string AggregateGroupByElementInput = "AggregateGroupByElementInput";
        public const string AggregateQueryInput = "AggregateQueryInput";
        public const string AggregateSelectColumnInput = "AggregateSelectColumnInput";
        public const string AggregateSelectElementInput = "AggregateSelectElementInput";
        public const string AggregateSelectFunctionInput = "AggregateSelectFunctionInput";
        public const string AppFeatureReleaseDataInput = "AppFeatureReleaseDataInput";
        public const string AppFeatureReleaseInput = "AppFeatureReleaseInput";
        public const string CalculatedCapabilityInput = "CalculatedCapabilityInput";
        public const string ColumnCapabilitiesInput = "ColumnCapabilitiesInput";
        public const string ColumnMappingInput = "ColumnMappingInput";
        public const string ColumnPropertyInput = "ColumnPropertyInput";
        public const string ColumnsConfigInput = "ColumnsConfigInput";
        public const string ColumnsMappingInput = "ColumnsMappingInput";
        public const string ConvertBoardToProjectInput = "ConvertBoardToProjectInput";
        public const string CreateAppInput = "CreateAppInput";
        public const string CreateDocBoardInput = "CreateDocBoardInput";
        public const string CreateDocInput = "CreateDocInput";
        public const string CreateDocWorkspaceInput = "CreateDocWorkspaceInput";
        public const string CreateDropdownColumnSettingsInput = "CreateDropdownColumnSettingsInput";
        public const string CreateDropdownLabelInput = "CreateDropdownLabelInput";
        public const string CreateFavoriteInput = "CreateFavoriteInput";
        public const string CreateFormTagInput = "CreateFormTagInput";
        public const string CreateQuestionInput = "CreateQuestionInput";
        public const string CreateStatusColumnSettingsInput = "CreateStatusColumnSettingsInput";
        public const string CreateStatusLabelInput = "CreateStatusLabelInput";
        public const string CreateTeamAttributesInput = "CreateTeamAttributesInput";
        public const string CreateTeamOptionsInput = "CreateTeamOptionsInput";
        public const string DateRangeInput = "DateRangeInput";
        public const string DeleteFavoriteInput = "DeleteFavoriteInput";
        public const string DeleteFormTagInput = "DeleteFormTagInput";
        public const string DependencyValueInput = "DependencyValueInput";
        public const string DynamicPosition = "DynamicPosition";
        public const string FileInput = "FileInput";
        public const string FormAccessibilityInput = "FormAccessibilityInput";
        public const string FormAfterSubmissionViewInput = "FormAfterSubmissionViewInput";
        public const string FormAppearanceInput = "FormAppearanceInput";
        public const string FormBackgroundInput = "FormBackgroundInput";
        public const string FormCloseDateInput = "FormCloseDateInput";
        public const string FormDraftSubmissionInput = "FormDraftSubmissionInput";
        public const string FormFeaturesInput = "FormFeaturesInput";
        public const string FormLayoutInput = "FormLayoutInput";
        public const string FormLogoInput = "FormLogoInput";
        public const string FormMondayInput = "FormMondayInput";
        public const string FormPasswordInput = "FormPasswordInput";
        public const string FormPreSubmissionViewInput = "FormPreSubmissionViewInput";
        public const string FormQuestionSettingsInput = "FormQuestionSettingsInput";
        public const string FormRedirectAfterSubmissionInput = "FormRedirectAfterSubmissionInput";
        public const string FormRequireLoginInput = "FormRequireLoginInput";
        public const string FormResponseLimitInput = "FormResponseLimitInput";
        public const string FormStartButtonInput = "FormStartButtonInput";
        public const string FormSubmitButtonInput = "FormSubmitButtonInput";
        public const string FormTextInput = "FormTextInput";
        public const string GrantMarketplaceAppDiscountData = "GrantMarketplaceAppDiscountData";
        public const string GroupByColumnConfigInput = "GroupByColumnConfigInput";
        public const string GroupByConditionInput = "GroupByConditionInput";
        public const string GroupBySettingsInput = "GroupBySettingsInput";
        public const string GroupBySortSettingsInput = "GroupBySortSettingsInput";
        public const string HierarchyObjectIdInputType = "HierarchyObjectIDInputType";
        public const string ItemNicknameInput = "ItemNicknameInput";
        public const string ItemsPageByColumnValuesQuery = "ItemsPageByColumnValuesQuery";
        public const string ItemsQuery = "ItemsQuery";
        public const string ItemsQueryGroup = "ItemsQueryGroup";
        public const string ItemsQueryOrderBy = "ItemsQueryOrderBy";
        public const string ItemsQueryRule = "ItemsQueryRule";
        public const string MarketplaceAiSearchInput = "MarketplaceAiSearchInput";
        public const string MarketplaceSearchInput = "MarketplaceSearchInput";
        public const string MetadataInput = "MetadataInput";
        public const string ObjectDynamicPositionInput = "ObjectDynamicPositionInput";
        public const string PaginationInput = "PaginationInput";
        public const string PayloadInput = "PayloadInput";
        public const string PhonePrefixPredefinedInput = "PhonePrefixPredefinedInput";
        public const string PrefillSettingsInput = "PrefillSettingsInput";
        public const string QuestionOptionInput = "QuestionOptionInput";
        public const string QuestionOrderInput = "QuestionOrderInput";
        public const string SetFormPasswordInput = "SetFormPasswordInput";
        public const string StatusCalculatedCapabilityInput = "StatusCalculatedCapabilityInput";
        public const string StatusColumnCapabilitiesInput = "StatusColumnCapabilitiesInput";
        public const string TableViewSettingsInput = "TableViewSettingsInput";
        public const string TimelineItemTimeRange = "TimelineItemTimeRange";
        public const string TriggerEventsFiltersInput = "TriggerEventsFiltersInput";
        public const string UpdateAppFeatureInput = "UpdateAppFeatureInput";
        public const string UpdateAppInput = "UpdateAppInput";
        public const string UpdateBoardHierarchyAttributesInput = "UpdateBoardHierarchyAttributesInput";
        public const string UpdateDependencyColumnInput = "UpdateDependencyColumnInput";
        public const string UpdateDropdownColumnSettingsInput = "UpdateDropdownColumnSettingsInput";
        public const string UpdateDropdownLabelInput = "UpdateDropdownLabelInput";
        public const string UpdateEmailDomainAttributesInput = "UpdateEmailDomainAttributesInput";
        public const string UpdateFormInput = "UpdateFormInput";
        public const string UpdateFormSettingsInput = "UpdateFormSettingsInput";
        public const string UpdateFormTagInput = "UpdateFormTagInput";
        public const string UpdateMention = "UpdateMention";
        public const string UpdateObjectHierarchyPositionInput = "UpdateObjectHierarchyPositionInput";
        public const string UpdateObjectInput = "UpdateObjectInput";
        public const string UpdateOverviewHierarchyAttributesInput = "UpdateOverviewHierarchyAttributesInput";
        public const string UpdateQuestionInput = "UpdateQuestionInput";
        public const string UpdateStatusColumnSettingsInput = "UpdateStatusColumnSettingsInput";
        public const string UpdateStatusLabelInput = "UpdateStatusLabelInput";
        public const string UpdateWorkspaceAttributesInput = "UpdateWorkspaceAttributesInput";
        public const string UserAttributesInput = "UserAttributesInput";
        public const string UserUpdateInput = "UserUpdateInput";
        public const string WidgetParentInput = "WidgetParentInput";

        public const string AggregateResult = "AggregateResult";
        public const string ColumnSettings = "ColumnSettings";
        public const string FileValueItem = "FileValueItem";
        public const string MirroredValue = "MirroredValue";

        public const string ColumnValue = "ColumnValue";

        public static readonly IReadOnlyDictionary<Type, string> ReverseMapping = new Dictionary<Type, string>() {
            { typeof(int), "Int" },
            { typeof(string), "String" },
            { typeof(bool), "Boolean" },
            { typeof(DateTimeOffset), "String" },
            { typeof(decimal), "Float" },
            { typeof(AggregateFromTableInput), "AggregateFromTableInput" },
            { typeof(AggregateGroupByElementInput), "AggregateGroupByElementInput" },
            { typeof(AggregateQueryInput), "AggregateQueryInput" },
            { typeof(AggregateSelectColumnInput), "AggregateSelectColumnInput" },
            { typeof(AggregateSelectElementInput), "AggregateSelectElementInput" },
            { typeof(AggregateSelectFunctionInput), "AggregateSelectFunctionInput" },
            { typeof(AppFeatureReleaseDataInput), "AppFeatureReleaseDataInput" },
            { typeof(AppFeatureReleaseInput), "AppFeatureReleaseInput" },
            { typeof(CalculatedCapabilityInput), "CalculatedCapabilityInput" },
            { typeof(ColumnCapabilitiesInput), "ColumnCapabilitiesInput" },
            { typeof(ColumnMappingInput), "ColumnMappingInput" },
            { typeof(ColumnPropertyInput), "ColumnPropertyInput" },
            { typeof(ColumnsConfigInput), "ColumnsConfigInput" },
            { typeof(ColumnsMappingInput), "ColumnsMappingInput" },
            { typeof(ConvertBoardToProjectInput), "ConvertBoardToProjectInput" },
            { typeof(CreateAppInput), "CreateAppInput" },
            { typeof(CreateDocBoardInput), "CreateDocBoardInput" },
            { typeof(CreateDocInput), "CreateDocInput" },
            { typeof(CreateDocWorkspaceInput), "CreateDocWorkspaceInput" },
            { typeof(CreateDropdownColumnSettingsInput), "CreateDropdownColumnSettingsInput" },
            { typeof(CreateDropdownLabelInput), "CreateDropdownLabelInput" },
            { typeof(CreateFavoriteInput), "CreateFavoriteInput" },
            { typeof(CreateFormTagInput), "CreateFormTagInput" },
            { typeof(CreateQuestionInput), "CreateQuestionInput" },
            { typeof(CreateStatusColumnSettingsInput), "CreateStatusColumnSettingsInput" },
            { typeof(CreateStatusLabelInput), "CreateStatusLabelInput" },
            { typeof(CreateTeamAttributesInput), "CreateTeamAttributesInput" },
            { typeof(CreateTeamOptionsInput), "CreateTeamOptionsInput" },
            { typeof(DateRangeInput), "DateRangeInput" },
            { typeof(DeleteFavoriteInput), "DeleteFavoriteInput" },
            { typeof(DeleteFormTagInput), "DeleteFormTagInput" },
            { typeof(DependencyValueInput), "DependencyValueInput" },
            { typeof(DynamicPosition), "DynamicPosition" },
            { typeof(FileInput), "FileInput" },
            { typeof(FormAccessibilityInput), "FormAccessibilityInput" },
            { typeof(FormAfterSubmissionViewInput), "FormAfterSubmissionViewInput" },
            { typeof(FormAppearanceInput), "FormAppearanceInput" },
            { typeof(FormBackgroundInput), "FormBackgroundInput" },
            { typeof(FormCloseDateInput), "FormCloseDateInput" },
            { typeof(FormDraftSubmissionInput), "FormDraftSubmissionInput" },
            { typeof(FormFeaturesInput), "FormFeaturesInput" },
            { typeof(FormLayoutInput), "FormLayoutInput" },
            { typeof(FormLogoInput), "FormLogoInput" },
            { typeof(FormMondayInput), "FormMondayInput" },
            { typeof(FormPasswordInput), "FormPasswordInput" },
            { typeof(FormPreSubmissionViewInput), "FormPreSubmissionViewInput" },
            { typeof(FormQuestionSettingsInput), "FormQuestionSettingsInput" },
            { typeof(FormRedirectAfterSubmissionInput), "FormRedirectAfterSubmissionInput" },
            { typeof(FormRequireLoginInput), "FormRequireLoginInput" },
            { typeof(FormResponseLimitInput), "FormResponseLimitInput" },
            { typeof(FormStartButtonInput), "FormStartButtonInput" },
            { typeof(FormSubmitButtonInput), "FormSubmitButtonInput" },
            { typeof(FormTextInput), "FormTextInput" },
            { typeof(GrantMarketplaceAppDiscountData), "GrantMarketplaceAppDiscountData" },
            { typeof(GroupByColumnConfigInput), "GroupByColumnConfigInput" },
            { typeof(GroupByConditionInput), "GroupByConditionInput" },
            { typeof(GroupBySettingsInput), "GroupBySettingsInput" },
            { typeof(GroupBySortSettingsInput), "GroupBySortSettingsInput" },
            { typeof(HierarchyObjectIDInputType), "HierarchyObjectIDInputType" },
            { typeof(ItemNicknameInput), "ItemNicknameInput" },
            { typeof(ItemsPageByColumnValuesQuery), "ItemsPageByColumnValuesQuery" },
            { typeof(ItemsQuery), "ItemsQuery" },
            { typeof(ItemsQueryGroup), "ItemsQueryGroup" },
            { typeof(ItemsQueryOrderBy), "ItemsQueryOrderBy" },
            { typeof(ItemsQueryRule), "ItemsQueryRule" },
            { typeof(MarketplaceAiSearchInput), "MarketplaceAiSearchInput" },
            { typeof(MarketplaceSearchInput), "MarketplaceSearchInput" },
            { typeof(MetadataInput), "MetadataInput" },
            { typeof(ObjectDynamicPositionInput), "ObjectDynamicPositionInput" },
            { typeof(PaginationInput), "PaginationInput" },
            { typeof(PayloadInput), "PayloadInput" },
            { typeof(PhonePrefixPredefinedInput), "PhonePrefixPredefinedInput" },
            { typeof(PrefillSettingsInput), "PrefillSettingsInput" },
            { typeof(QuestionOptionInput), "QuestionOptionInput" },
            { typeof(QuestionOrderInput), "QuestionOrderInput" },
            { typeof(SetFormPasswordInput), "SetFormPasswordInput" },
            { typeof(StatusCalculatedCapabilityInput), "StatusCalculatedCapabilityInput" },
            { typeof(StatusColumnCapabilitiesInput), "StatusColumnCapabilitiesInput" },
            { typeof(TableViewSettingsInput), "TableViewSettingsInput" },
            { typeof(TimelineItemTimeRange), "TimelineItemTimeRange" },
            { typeof(TriggerEventsFiltersInput), "TriggerEventsFiltersInput" },
            { typeof(UpdateAppFeatureInput), "UpdateAppFeatureInput" },
            { typeof(UpdateAppInput), "UpdateAppInput" },
            { typeof(UpdateBoardHierarchyAttributesInput), "UpdateBoardHierarchyAttributesInput" },
            { typeof(UpdateDependencyColumnInput), "UpdateDependencyColumnInput" },
            { typeof(UpdateDropdownColumnSettingsInput), "UpdateDropdownColumnSettingsInput" },
            { typeof(UpdateDropdownLabelInput), "UpdateDropdownLabelInput" },
            { typeof(UpdateEmailDomainAttributesInput), "UpdateEmailDomainAttributesInput" },
            { typeof(UpdateFormInput), "UpdateFormInput" },
            { typeof(UpdateFormSettingsInput), "UpdateFormSettingsInput" },
            { typeof(UpdateFormTagInput), "UpdateFormTagInput" },
            { typeof(UpdateMention), "UpdateMention" },
            { typeof(UpdateObjectHierarchyPositionInput), "UpdateObjectHierarchyPositionInput" },
            { typeof(UpdateObjectInput), "UpdateObjectInput" },
            { typeof(UpdateOverviewHierarchyAttributesInput), "UpdateOverviewHierarchyAttributesInput" },
            { typeof(UpdateQuestionInput), "UpdateQuestionInput" },
            { typeof(UpdateStatusColumnSettingsInput), "UpdateStatusColumnSettingsInput" },
            { typeof(UpdateStatusLabelInput), "UpdateStatusLabelInput" },
            { typeof(UpdateWorkspaceAttributesInput), "UpdateWorkspaceAttributesInput" },
            { typeof(UserAttributesInput), "UserAttributesInput" },
            { typeof(UserUpdateInput), "UserUpdateInput" },
            { typeof(WidgetParentInput), "WidgetParentInput" }
        };
    }
}
