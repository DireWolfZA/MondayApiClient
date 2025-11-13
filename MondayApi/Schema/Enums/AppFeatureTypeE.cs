using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AppFeatureTypeE {
        [EnumMember(Value = "OAUTH")]
        Oauth,
        [EnumMember(Value = "BOARD_VIEW")]
        BoardView,
        [EnumMember(Value = "INTEGRATION")]
        Integration,
        [EnumMember(Value = "SOLUTION")]
        Solution,
        [EnumMember(Value = "ITEM_VIEW")]
        ItemView,
        [EnumMember(Value = "DASHBOARD_WIDGET")]
        DashboardWidget,
        [EnumMember(Value = "ACCOUNT_SETTINGS_VIEW")]
        AccountSettingsView,
        [EnumMember(Value = "DOC_ACTIONS")]
        DocActions,
        [EnumMember(Value = "OBJECT")]
        Object,
        [EnumMember(Value = "WORKSPACE_VIEW")]
        WorkspaceView,
        [EnumMember(Value = "AI")]
        Ai,
        [EnumMember(Value = "AI_BOARD_MAIN_MENU_HEADER")]
        AiBoardMainMenuHeader,
        [EnumMember(Value = "AI_ITEM_UPDATE_ACTIONS")]
        AiItemUpdateActions,
        [EnumMember(Value = "AI_DOC_SLASH_COMMAND")]
        AiDocSlashCommand,
        [EnumMember(Value = "AI_DOC_CONTEXTUAL_MENU")]
        AiDocContextualMenu,
        [EnumMember(Value = "AI_DOC_QUICK_START")]
        AiDocQuickStart,
        [EnumMember(Value = "AI_DOC_TOP_BAR")]
        AiDocTopBar,
        [EnumMember(Value = "COLUMN_TEMPLATE")]
        ColumnTemplate,
        [EnumMember(Value = "AI_IC_ASSISTANT_HELP_CENTER")]
        AiIcAssistantHelpCenter,
        [EnumMember(Value = "APP_WIZARD")]
        AppWizard,
        [EnumMember(Value = "GROUP_MENU_ACTION")]
        GroupMenuAction,
        [EnumMember(Value = "ITEM_MENU_ACTION")]
        ItemMenuAction,
        [EnumMember(Value = "NOTIFICATION_KIND")]
        NotificationKind,
        [EnumMember(Value = "NOTIFICATION_SETTING_KIND")]
        NotificationSettingKind,
        [EnumMember(Value = "BLOCK")]
        Block,
        [EnumMember(Value = "ITEM_BATCH_ACTION")]
        ItemBatchAction,
        [EnumMember(Value = "AI_FORMULA")]
        AiFormula,
        [EnumMember(Value = "AI_ITEM_EMAILS_AND_ACTIVITIES_ACTIONS")]
        AiItemEmailsAndActivitiesActions,
        [EnumMember(Value = "AI_EMAILS_AND_ACTIVITIES_HEADER_ACTIONS")]
        AiEmailsAndActivitiesHeaderActions,
        [EnumMember(Value = "FIELD_TYPE")]
        FieldType,
        [EnumMember(Value = "PRODUCT")]
        Product,
        [EnumMember(Value = "PRODUCT_VIEW")]
        ProductView,
        [EnumMember(Value = "BOARD_COLUMN_ACTION")]
        BoardColumnAction,
        [EnumMember(Value = "BOARD_COLUMN_EXTENSION")]
        BoardColumnExtension,
        [EnumMember(Value = "PACKAGED_BLOCK")]
        PackagedBlock,
        [EnumMember(Value = "CREDENTIALS")]
        Credentials,
        [EnumMember(Value = "TOPBAR")]
        Topbar,
        [EnumMember(Value = "WORKFLOW_TEMPLATE")]
        WorkflowTemplate,
        [EnumMember(Value = "COLUMN")]
        Column,
        [EnumMember(Value = "SUB_WORKFLOW")]
        SubWorkflow,
        [EnumMember(Value = "BOARD_HEADER_ACTION")]
        BoardHeaderAction,
        [EnumMember(Value = "DIALOG")]
        Dialog,
        [EnumMember(Value = "DATA_ENTITY")]
        DataEntity,
        [EnumMember(Value = "SYNCABLE_RESOURCE")]
        SyncableResource,
        [EnumMember(Value = "AI_AGENT")]
        AiAgent,
        [EnumMember(Value = "SURFACE_VIEW")]
        SurfaceView,
        [EnumMember(Value = "GROWTH_CONFIG")]
        GrowthConfig,
        [EnumMember(Value = "MODAL")]
        Modal,
        [EnumMember(Value = "ADMIN_VIEW")]
        AdminView,
        [EnumMember(Value = "DIGITAL_WORKER")]
        DigitalWorker,
        [EnumMember(Value = "AI_AGENT_SKILL")]
        AiAgentSkill
    }
}
