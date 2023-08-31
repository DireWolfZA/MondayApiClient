using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WebhookEventType {
        [EnumMember(Value = "change_column_value")]
        ChangeColumnValue,
        [EnumMember(Value = "create_column")]
        CreateColumn,
        [EnumMember(Value = "change_status_column_value")]
        ChangeStatusColumnValue,
        [EnumMember(Value = "change_subitem_column_value")]
        ChangeSubitemColumnValue,
        [EnumMember(Value = "change_specific_column_value")]
        ChangeSpecificColumnValue,
        [EnumMember(Value = "create_item")]
        CreateItem,
        [EnumMember(Value = "create_subitem")]
        CreateSubitem,
        [EnumMember(Value = "create_update")]
        CreateUpdate,
        [EnumMember(Value = "edit_update")]
        EditUpdate,
        [EnumMember(Value = "delete_update")]
        DeleteUpdate,
        [EnumMember(Value = "create_subitem_update")]
        CreateSubitemUpdate,
        [EnumMember(Value = "change_subitem_name")]
        ChangeSubitemName,
        [EnumMember(Value = "change_name")]
        ChangeName,
        [EnumMember(Value = "item_deleted")]
        ItemDeleted,
        [EnumMember(Value = "subitem_deleted")]
        SubitemDeleted,
        [EnumMember(Value = "item_archived")]
        ItemArchived,
        [EnumMember(Value = "subitem_archived")]
        SubitemArchived,
        [EnumMember(Value = "item_restored")]
        ItemRestored,
        [EnumMember(Value = "item_moved_to_any_group")]
        ItemMovedToAnyGroup,
        [EnumMember(Value = "item_moved_to_specific_group")]
        ItemMovedToSpecificGroup,
        [EnumMember(Value = "move_subitem")]
        MoveSubitem
    }
}
