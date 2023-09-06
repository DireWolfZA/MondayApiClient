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

        public const string AccountProductKind = "AccountProductKind";
        public const string AssetsSource = "AssetsSource";
        public const string BoardAttributes = "BoardAttributes";
        public const string BoardKind = "BoardKind";
        public const string BoardObjectType = "BoardObjectType";
        public const string BoardsOrderBy = "BoardsOrderBy";
        public const string BoardSubscriberKind = "BoardSubscriberKind";
        public const string ColumnProperty = "ColumnProperty";
        public const string ColumnType = "ColumnType";
        public const string DocBlockContentType = "DocBlockContentType";
        public const string DocsOrderBy = "DocsOrderBy";
        public const string DuplicateBoardType = "DuplicateBoardType";
        public const string FileLinkValueKind = "FileLinkValueKind";
        public const string FirstDayOfTheWeek = "FirstDayOfTheWeek";
        public const string FolderColor = "FolderColor";
        public const string GroupAttributes = "GroupAttributes";
        public const string ItemsOrderByDirection = "ItemsOrderByDirection";
        public const string ItemsQueryOperator = "ItemsQueryOperator";
        public const string ItemsQueryRuleOperator = "ItemsQueryRuleOperator";
        public const string Kind = "Kind";
        public const string NotificationTargetType = "NotificationTargetType";
        public const string PositionRelative = "PositionRelative";
        public const string State = "State";
        public const string UserKind = "UserKind";
        public const string VersionKind = "VersionKind";
        public const string WebhookEventType = "WebhookEventType";
        public const string WorkspaceKind = "WorkspaceKind";
        public const string WorkspacesOrderBy = "WorkspacesOrderBy";
        public const string WorkspaceSubscriberKind = "WorkspaceSubscriberKind";

        public const string Account = "Account";
        public const string AccountProduct = "AccountProduct";
        public const string ActivityLogType = "ActivityLogType";
        public const string AppMonetizationStatus = "AppMonetizationStatus";
        public const string AppSubscription = "AppSubscription";
        public const string Asset = "Asset";
        public const string Board = "Board";
        public const string BoardDuplication = "BoardDuplication";
        public const string BoardRelationValue = "BoardRelationValue";
        public const string BoardView = "BoardView";
        public const string ButtonValue = "ButtonValue";
        public const string CheckboxValue = "CheckboxValue";
        public const string ColorPickerValue = "ColorPickerValue";
        public const string Column = "Column";
        public const string Complexity = "Complexity";
        public const string Country = "Country";
        public const string CountryValue = "CountryValue";
        public const string CreationLogValue = "CreationLogValue";
        public const string DateValue = "DateValue";
        public const string DependencyValue = "DependencyValue";
        public const string Document = "Document";
        public const string DocumentBlock = "DocumentBlock";
        public const string DocumentBlockIDOnly = "DocumentBlockIdOnly";
        public const string DocValue = "DocValue";
        public const string DropdownValue = "DropdownValue";
        public const string DropdownValueOption = "DropdownValueOption";
        public const string EmailValue = "EmailValue";
        public const string FileAssetValue = "FileAssetValue";
        public const string FileDocValue = "FileDocValue";
        public const string FileLinkValue = "FileLinkValue";
        public const string FileValue = "FileValue";
        public const string Folder = "Folder";
        public const string FormulaValue = "FormulaValue";
        public const string Group = "Group";
        public const string HourValue = "HourValue";
        public const string IntegrationValue = "IntegrationValue";
        public const string Item = "Item";
        public const string ItemIDValue = "ItemIdValue";
        public const string ItemsResponse = "ItemsResponse";
        public const string LastUpdatedValue = "LastUpdatedValue";
        public const string LinkValue = "LinkValue";
        public const string LocationValue = "LocationValue";
        public const string LongTextValue = "LongTextValue";
        public const string MirroredItem = "MirroredItem";
        public const string MirrorValue = "MirrorValue";
        public const string Mutation = "Mutation";
        public const string Notification = "Notification";
        public const string NumbersValue = "NumbersValue";
        public const string OutOfOffice = "OutOfOffice";
        public const string PeopleEntity = "PeopleEntity";
        public const string PeopleValue = "PeopleValue";
        public const string PhoneValue = "PhoneValue";
        public const string Plan = "Plan";
        public const string ProgressValue = "ProgressValue";
        public const string Query = "Query";
        public const string RatingValue = "RatingValue";
        public const string Reply = "Reply";
        public const string StatusLabelStyle = "StatusLabelStyle";
        public const string StatusValue = "StatusValue";
        public const string SubtasksValue = "SubtasksValue";
        public const string Tag = "Tag";
        public const string TagsValue = "TagsValue";
        public const string Team = "Team";
        public const string TeamValue = "TeamValue";
        public const string TextValue = "TextValue";
        public const string TimelineValue = "TimelineValue";
        public const string TimeTrackingHistoryItem = "TimeTrackingHistoryItem";
        public const string TimeTrackingValue = "TimeTrackingValue";
        public const string UnsupportedValue = "UnsupportedValue";
        public const string Update = "Update";
        public const string User = "User";
        public const string Version = "Version";
        public const string VoteValue = "VoteValue";
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
        public const string ItemsPageByColumnValuesQuery = "ItemsPageByColumnValuesQuery";
        public const string ItemsQuery = "ItemsQuery";
        public const string ItemsQueryOrderBy = "ItemsQueryOrderBy";
        public const string ItemsQueryRule = "ItemsQueryRule";

        public const string FileValueItem = "FileValueItem";
        public const string MirroredValue = "MirroredValue";

        public const string ColumnValue = "ColumnValue";

        public static readonly IReadOnlyDictionary<Type, string> ReverseMapping = new Dictionary<Type, string>() {
            { typeof(string), "String" },
            { typeof(Guid), "ID" },
            { typeof(bool), "Boolean" },
            { typeof(DateTimeOffset), "String" },
            { typeof(int), "Int" },
            { typeof(decimal), "Float" },
            { typeof(ColumnMappingInput), "ColumnMappingInput" },
            { typeof(CreateDocBoardInput), "CreateDocBoardInput" },
            { typeof(CreateDocInput), "CreateDocInput" },
            { typeof(CreateDocWorkspaceInput), "CreateDocWorkspaceInput" },
            { typeof(ItemsPageByColumnValuesQuery), "ItemsPageByColumnValuesQuery" },
            { typeof(ItemsQuery), "ItemsQuery" },
            { typeof(ItemsQueryOrderBy), "ItemsQueryOrderBy" },
            { typeof(ItemsQueryRule), "ItemsQueryRule" }
        };
    }
}
