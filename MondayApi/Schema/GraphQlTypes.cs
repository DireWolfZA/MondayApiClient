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
    public static class GraphQlTypes
    {
        public const string Boolean = "Boolean";
        public const string Date = "Date";
        public const string File = "File";
        public const string Float = "Float";
        public const string Id = "ID";
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
        public const string FirstDayOfTheWeek = "FirstDayOfTheWeek";
        public const string FolderColor = "FolderColor";
        public const string GroupAttributes = "GroupAttributes";
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
        public const string BoardView = "BoardView";
        public const string Column = "Column";
        public const string ColumnValue = "ColumnValue";
        public const string Complexity = "Complexity";
        public const string Document = "Document";
        public const string DocumentBlock = "DocumentBlock";
        public const string DocumentBlockIdOnly = "DocumentBlockIdOnly";
        public const string Folder = "Folder";
        public const string Group = "Group";
        public const string Item = "Item";
        public const string Mutation = "Mutation";
        public const string Notification = "Notification";
        public const string OutOfOffice = "OutOfOffice";
        public const string Plan = "Plan";
        public const string Query = "Query";
        public const string Reply = "Reply";
        public const string Tag = "Tag";
        public const string Team = "Team";
        public const string Update = "Update";
        public const string User = "User";
        public const string Version = "Version";
        public const string Webhook = "Webhook";
        public const string Workspace = "Workspace";
        public const string WorkspaceIcon = "WorkspaceIcon";
        public const string WorkspaceSettings = "WorkspaceSettings";

        public const string CreateDocBoardInput = "CreateDocBoardInput";
        public const string CreateDocInput = "CreateDocInput";
        public const string CreateDocWorkspaceInput = "CreateDocWorkspaceInput";

        public static readonly IReadOnlyDictionary<Type, string> ReverseMapping =
            new Dictionary<Type, string>
            {
                { typeof(string), "String" },
                { typeof(int), "Int" },
                { typeof(bool), "Boolean" },
                { typeof(DateTimeOffset), "String" },
                { typeof(Guid), "ID" },
                { typeof(decimal), "Float" },
                { typeof(CreateDocBoardInput), "CreateDocBoardInput" },
                { typeof(CreateDocInput), "CreateDocInput" },
                { typeof(CreateDocWorkspaceInput), "CreateDocWorkspaceInput" }
            };
}
}
