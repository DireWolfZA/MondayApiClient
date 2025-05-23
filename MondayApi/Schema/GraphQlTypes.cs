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
        public const string String = "String";

        public const string ActivateUsersErrorCode = "ActivateUsersErrorCode";
        public const string AssetsSource = "AssetsSource";
        public const string AssignTeamOwnersErrorCode = "AssignTeamOwnersErrorCode";
        public const string BaseRoleName = "BaseRoleName";
        public const string BoardAttributes = "BoardAttributes";
        public const string BoardKind = "BoardKind";
        public const string BoardObjectType = "BoardObjectType";
        public const string BoardsOrderBy = "BoardsOrderBy";
        public const string BoardSubscriberKind = "BoardSubscriberKind";
        public const string ColumnProperty = "ColumnProperty";
        public const string ColumnType = "ColumnType";
        public const string CustomActivityColor = "CustomActivityColor";
        public const string CustomActivityIcon = "CustomActivityIcon";
        public const string DeactivateUsersErrorCode = "DeactivateUsersErrorCode";
        public const string DiscountPeriod = "DiscountPeriod";
        public const string DocBlockContentType = "DocBlockContentType";
        public const string DocsOrderBy = "DocsOrderBy";
        public const string DuplicateBoardType = "DuplicateBoardType";
        public const string FieldTypeRelationType = "FieldTypeRelationType";
        public const string FieldTypeState = "FieldTypeState";
        public const string FileColumnValue = "FileColumnValue";
        public const string FileLinkValueKind = "FileLinkValueKind";
        public const string FirstDayOfTheWeek = "FirstDayOfTheWeek";
        public const string FolderColor = "FolderColor";
        public const string FolderCustomIcon = "FolderCustomIcon";
        public const string FolderFontWeight = "FolderFontWeight";
        public const string GroupAttributes = "GroupAttributes";
        public const string InviteUsersErrorCode = "InviteUsersErrorCode";
        public const string ItemsOrderByDirection = "ItemsOrderByDirection";
        public const string ItemsQueryOperator = "ItemsQueryOperator";
        public const string ItemsQueryRuleOperator = "ItemsQueryRuleOperator";
        public const string Kind = "Kind";
        public const string ManagedColumnState = "ManagedColumnState";
        public const string ManagedColumnTypes = "ManagedColumnTypes";
        public const string NotificationTargetType = "NotificationTargetType";
        public const string NumberValueUnitDirection = "NumberValueUnitDirection";
        public const string PositionRelative = "PositionRelative";
        public const string PrimitiveTypes = "PrimitiveTypes";
        public const string Product = "Product";
        public const string RemoveTeamOwnersErrorCode = "RemoveTeamOwnersErrorCode";
        public const string State = "State";
        public const string StatusColumnColors = "StatusColumnColors";
        public const string SubscriptionDiscountModelType = "SubscriptionDiscountModelType";
        public const string SubscriptionDiscountType = "SubscriptionDiscountType";
        public const string SubscriptionPeriodType = "SubscriptionPeriodType";
        public const string SubscriptionStatus = "SubscriptionStatus";
        public const string UpdateEmailDomainErrorCode = "UpdateEmailDomainErrorCode";
        public const string UpdateUserAttributesErrorCode = "UpdateUserAttributesErrorCode";
        public const string UpdateUsersRoleErrorCode = "UpdateUsersRoleErrorCode";
        public const string UserKind = "UserKind";
        public const string UserRole = "UserRole";
        public const string VersionKind = "VersionKind";
        public const string WebhookEventType = "WebhookEventType";
        public const string WorkspaceKind = "WorkspaceKind";
        public const string WorkspacesOrderBy = "WorkspacesOrderBy";
        public const string WorkspaceSubscriberKind = "WorkspaceSubscriberKind";

        public const string Account = "Account";
        public const string AccountProduct = "AccountProduct";
        public const string AccountRole = "AccountRole";
        public const string ActivateUsersError = "ActivateUsersError";
        public const string ActivateUsersResult = "ActivateUsersResult";
        public const string ActivityLogType = "ActivityLogType";
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
        public const string Asset = "Asset";
        public const string AssignTeamOwnersError = "AssignTeamOwnersError";
        public const string AssignTeamOwnersResult = "AssignTeamOwnersResult";
        public const string BaseFieldType = "BaseFieldType";
        public const string BatchExtendTrialPeriod = "BatchExtendTrialPeriod";
        public const string Block = "Block";
        public const string BlocksResult = "BlocksResult";
        public const string Board = "Board";
        public const string BoardDuplication = "BoardDuplication";
        public const string BoardRelationValue = "BoardRelationValue";
        public const string BoardView = "BoardView";
        public const string ButtonValue = "ButtonValue";
        public const string ChangeTeamMembershipsResult = "ChangeTeamMembershipsResult";
        public const string CheckboxValue = "CheckboxValue";
        public const string ColorPickerValue = "ColorPickerValue";
        public const string Column = "Column";
        public const string Complexity = "Complexity";
        public const string ConnectProjectResult = "ConnectProjectResult";
        public const string Country = "Country";
        public const string CountryValue = "CountryValue";
        public const string CreationLogValue = "CreationLogValue";
        public const string CustomActivity = "CustomActivity";
        public const string CustomFieldMetas = "CustomFieldMetas";
        public const string CustomFieldValue = "CustomFieldValue";
        public const string CustomInputFieldConfig = "CustomInputFieldConfig";
        public const string CustomOutputFieldConfig = "CustomOutputFieldConfig";
        public const string DailyAnalytics = "DailyAnalytics";
        public const string DailyLimit = "DailyLimit";
        public const string DateValue = "DateValue";
        public const string DeactivateUsersError = "DeactivateUsersError";
        public const string DeactivateUsersResult = "DeactivateUsersResult";
        public const string DeleteMarketplaceAppDiscount = "DeleteMarketplaceAppDiscount";
        public const string DeleteMarketplaceAppDiscountResult = "DeleteMarketplaceAppDiscountResult";
        public const string DependencyConfig = "DependencyConfig";
        public const string DependencyField = "DependencyField";
        public const string DependencyValue = "DependencyValue";
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
        public const string ExtendTrialPeriod = "ExtendTrialPeriod";
        public const string FieldInformation = "FieldInformation";
        public const string FieldTypeImplementation = "FieldTypeImplementation";
        public const string FileAssetValue = "FileAssetValue";
        public const string FileDocValue = "FileDocValue";
        public const string FileLinkValue = "FileLinkValue";
        public const string FileValue = "FileValue";
        public const string Folder = "Folder";
        public const string FormulaValue = "FormulaValue";
        public const string GrantMarketplaceAppDiscount = "GrantMarketplaceAppDiscount";
        public const string GrantMarketplaceAppDiscountResult = "GrantMarketplaceAppDiscountResult";
        public const string Group = "Group";
        public const string GroupValue = "GroupValue";
        public const string HourValue = "HourValue";
        public const string InputFieldConstraints = "InputFieldConstraints";
        public const string IntegrationValue = "IntegrationValue";
        public const string InterfaceInputFieldConfig = "InterfaceInputFieldConfig";
        public const string InviteUsersError = "InviteUsersError";
        public const string InviteUsersResult = "InviteUsersResult";
        public const string Item = "Item";
        public const string ItemIDValue = "ItemIdValue";
        public const string ItemsResponse = "ItemsResponse";
        public const string LastUpdatedValue = "LastUpdatedValue";
        public const string Like = "Like";
        public const string LinkValue = "LinkValue";
        public const string LocationValue = "LocationValue";
        public const string LongTextValue = "LongTextValue";
        public const string ManagedColumn = "ManagedColumn";
        public const string MarketplaceAppDiscount = "MarketplaceAppDiscount";
        public const string MirroredItem = "MirroredItem";
        public const string MirrorValue = "MirrorValue";
        public const string Mutation = "Mutation";
        public const string NextPageRequestData = "NextPageRequestData";
        public const string Notification = "Notification";
        public const string NumbersValue = "NumbersValue";
        public const string Option = "Option";
        public const string OutOfOffice = "OutOfOffice";
        public const string OutputFieldConstraints = "OutputFieldConstraints";
        public const string PeopleEntity = "PeopleEntity";
        public const string PeopleValue = "PeopleValue";
        public const string PersonValue = "PersonValue";
        public const string PhoneValue = "PhoneValue";
        public const string Plan = "Plan";
        public const string PlatformApi = "PlatformApi";
        public const string PlatformApiDailyAnalyticsByApp = "PlatformApiDailyAnalyticsByApp";
        public const string PlatformApiDailyAnalyticsByDay = "PlatformApiDailyAnalyticsByDay";
        public const string PlatformApiDailyAnalyticsByUser = "PlatformApiDailyAnalyticsByUser";
        public const string PrimitiveFieldType = "PrimitiveFieldType";
        public const string PrimitiveInputFieldConfig = "PrimitiveInputFieldConfig";
        public const string PrimitiveOutputFieldConfig = "PrimitiveOutputFieldConfig";
        public const string ProgressValue = "ProgressValue";
        public const string Query = "Query";
        public const string RatingValue = "RatingValue";
        public const string RemoteOptionsResponse = "RemoteOptionsResponse";
        public const string RemoveTeamOwnersError = "RemoveTeamOwnersError";
        public const string RemoveTeamOwnersResult = "RemoveTeamOwnersResult";
        public const string Reply = "Reply";
        public const string StatusColumnSettings = "StatusColumnSettings";
        public const string StatusLabel = "StatusLabel";
        public const string StatusLabelStyle = "StatusLabelStyle";
        public const string StatusManagedColumn = "StatusManagedColumn";
        public const string StatusValue = "StatusValue";
        public const string SubfieldsFieldType = "SubfieldsFieldType";
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
        public const string UnsupportedValue = "UnsupportedValue";
        public const string Update = "Update";
        public const string UpdateEmailDomainError = "UpdateEmailDomainError";
        public const string UpdateEmailDomainResult = "UpdateEmailDomainResult";
        public const string UpdatePin = "UpdatePin";
        public const string UpdateUserAttributesError = "UpdateUserAttributesError";
        public const string UpdateUserAttributesResult = "UpdateUserAttributesResult";
        public const string UpdateUsersRoleError = "UpdateUsersRoleError";
        public const string UpdateUsersRoleResult = "UpdateUsersRoleResult";
        public const string User = "User";
        public const string Version = "Version";
        public const string VoteValue = "VoteValue";
        public const string Watcher = "Watcher";
        public const string Webhook = "Webhook";
        public const string WeekValue = "WeekValue";
        public const string Workspace = "Workspace";
        public const string WorkspaceIcon = "WorkspaceIcon";
        public const string WorkspaceSettings = "WorkspaceSettings";
        public const string WorldClockValue = "WorldClockValue";

        public const string ColumnMappingInput = "ColumnMappingInput";
        public const string CreateDocBoardInput = "CreateDocBoardInput";
        public const string CreateDocInput = "CreateDocInput";
        public const string CreateDocWorkspaceInput = "CreateDocWorkspaceInput";
        public const string CreateDropdownColumnSettingsInput = "CreateDropdownColumnSettingsInput";
        public const string CreateDropdownLabelInput = "CreateDropdownLabelInput";
        public const string CreateStatusColumnSettingsInput = "CreateStatusColumnSettingsInput";
        public const string CreateStatusLabelInput = "CreateStatusLabelInput";
        public const string CreateTeamAttributesInput = "CreateTeamAttributesInput";
        public const string CreateTeamOptionsInput = "CreateTeamOptionsInput";
        public const string FileInput = "FileInput";
        public const string GetBlocksInput = "GetBlocksInput";
        public const string GrantMarketplaceAppDiscountData = "GrantMarketplaceAppDiscountData";
        public const string ItemsPageByColumnValuesQuery = "ItemsPageByColumnValuesQuery";
        public const string ItemsQuery = "ItemsQuery";
        public const string ItemsQueryGroup = "ItemsQueryGroup";
        public const string ItemsQueryOrderBy = "ItemsQueryOrderBy";
        public const string ItemsQueryRule = "ItemsQueryRule";
        public const string RemoteOptionsInput = "RemoteOptionsInput";
        public const string TimelineItemTimeRange = "TimelineItemTimeRange";
        public const string UpdateDropdownColumnSettingsInput = "UpdateDropdownColumnSettingsInput";
        public const string UpdateDropdownLabelInput = "UpdateDropdownLabelInput";
        public const string UpdateEmailDomainAttributesInput = "UpdateEmailDomainAttributesInput";
        public const string UpdateStatusColumnSettingsInput = "UpdateStatusColumnSettingsInput";
        public const string UpdateStatusLabelInput = "UpdateStatusLabelInput";
        public const string UpdateWorkspaceAttributesInput = "UpdateWorkspaceAttributesInput";
        public const string UserAttributesInput = "UserAttributesInput";
        public const string UserUpdateInput = "UserUpdateInput";

        public const string ColumnSettings = "ColumnSettings";
        public const string FileValueItem = "FileValueItem";
        public const string MirroredValue = "MirroredValue";

        public const string ColumnValue = "ColumnValue";
        public const string FieldType = "FieldType";
        public const string InputFieldConfig = "InputFieldConfig";
        public const string OutputFieldConfig = "OutputFieldConfig";

        public static readonly IReadOnlyDictionary<Type, string> ReverseMapping = new Dictionary<Type, string>() {
            { typeof(int), "Int" },
            { typeof(string), "String" },
            { typeof(bool), "Boolean" },
            { typeof(DateTimeOffset), "String" },
            { typeof(decimal), "Float" },
            { typeof(ColumnMappingInput), "ColumnMappingInput" },
            { typeof(CreateDocBoardInput), "CreateDocBoardInput" },
            { typeof(CreateDocInput), "CreateDocInput" },
            { typeof(CreateDocWorkspaceInput), "CreateDocWorkspaceInput" },
            { typeof(CreateDropdownColumnSettingsInput), "CreateDropdownColumnSettingsInput" },
            { typeof(CreateDropdownLabelInput), "CreateDropdownLabelInput" },
            { typeof(CreateStatusColumnSettingsInput), "CreateStatusColumnSettingsInput" },
            { typeof(CreateStatusLabelInput), "CreateStatusLabelInput" },
            { typeof(CreateTeamAttributesInput), "CreateTeamAttributesInput" },
            { typeof(CreateTeamOptionsInput), "CreateTeamOptionsInput" },
            { typeof(FileInput), "FileInput" },
            { typeof(GetBlocksInput), "GetBlocksInput" },
            { typeof(GrantMarketplaceAppDiscountData), "GrantMarketplaceAppDiscountData" },
            { typeof(ItemsPageByColumnValuesQuery), "ItemsPageByColumnValuesQuery" },
            { typeof(ItemsQuery), "ItemsQuery" },
            { typeof(ItemsQueryGroup), "ItemsQueryGroup" },
            { typeof(ItemsQueryOrderBy), "ItemsQueryOrderBy" },
            { typeof(ItemsQueryRule), "ItemsQueryRule" },
            { typeof(RemoteOptionsInput), "RemoteOptionsInput" },
            { typeof(TimelineItemTimeRange), "TimelineItemTimeRange" },
            { typeof(UpdateDropdownColumnSettingsInput), "UpdateDropdownColumnSettingsInput" },
            { typeof(UpdateDropdownLabelInput), "UpdateDropdownLabelInput" },
            { typeof(UpdateEmailDomainAttributesInput), "UpdateEmailDomainAttributesInput" },
            { typeof(UpdateStatusColumnSettingsInput), "UpdateStatusColumnSettingsInput" },
            { typeof(UpdateStatusLabelInput), "UpdateStatusLabelInput" },
            { typeof(UpdateWorkspaceAttributesInput), "UpdateWorkspaceAttributesInput" },
            { typeof(UserAttributesInput), "UserAttributesInput" },
            { typeof(UserUpdateInput), "UserUpdateInput" }
        };
    }
}
