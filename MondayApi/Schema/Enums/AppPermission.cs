using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AppPermission {
        [EnumMember(Value = "ME_READ")]
        MeRead,
        [EnumMember(Value = "BOARDS_READ")]
        BoardsRead,
        [EnumMember(Value = "BOARDS_WRITE")]
        BoardsWrite,
        [EnumMember(Value = "WORKSPACES_READ")]
        WorkspacesRead,
        [EnumMember(Value = "WORKSPACES_WRITE")]
        WorkspacesWrite,
        [EnumMember(Value = "USERS_READ")]
        UsersRead,
        [EnumMember(Value = "USERS_WRITE")]
        UsersWrite,
        [EnumMember(Value = "ACCOUNT_READ")]
        AccountRead,
        [EnumMember(Value = "UPDATES_READ")]
        UpdatesRead,
        [EnumMember(Value = "UPDATES_WRITE")]
        UpdatesWrite,
        [EnumMember(Value = "TAGS_READ")]
        TagsRead,
        [EnumMember(Value = "ASSETS_READ")]
        AssetsRead,
        [EnumMember(Value = "TEAMS_READ")]
        TeamsRead,
        [EnumMember(Value = "TEAMS_WRITE")]
        TeamsWrite,
        [EnumMember(Value = "DEPARTMENTS_READ")]
        DepartmentsRead,
        [EnumMember(Value = "DEPARTMENTS_WRITE")]
        DepartmentsWrite,
        [EnumMember(Value = "NOTIFICATIONS_WRITE")]
        NotificationsWrite,
        [EnumMember(Value = "WEBHOOKS_WRITE")]
        WebhooksWrite,
        [EnumMember(Value = "WEBHOOKS_READ")]
        WebhooksRead,
        [EnumMember(Value = "DOCS_READ")]
        DocsRead,
        [EnumMember(Value = "DOCS_WRITE")]
        DocsWrite
    }
}
