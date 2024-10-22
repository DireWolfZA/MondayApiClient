using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WebhookEventType {
        [EnumMember(Value = "change_column_value")]
        ChangeColumnValue,
        [EnumMember(Value = "change_name")]
        ChangeName,
        [EnumMember(Value = "change_specific_column_value")]
        ChangeSpecificColumnValue,
        [EnumMember(Value = "change_status_column_value")]
        ChangeStatusColumnValue,
        [EnumMember(Value = "change_subitem_column_value")]
        ChangeSubitemColumnValue,
        [EnumMember(Value = "change_subitem_name")]
        ChangeSubitemName,
        [EnumMember(Value = "create_column")]
        CreateColumn,
        [EnumMember(Value = "create_item")]
        CreateItem,
        [EnumMember(Value = "create_subitem")]
        CreateSubitem,
        [EnumMember(Value = "create_subitem_update")]
        CreateSubitemUpdate,
        [EnumMember(Value = "create_update")]
        CreateUpdate,
        [EnumMember(Value = "delete_update")]
        DeleteUpdate,
        [EnumMember(Value = "edit_update")]
        EditUpdate,
        [EnumMember(Value = "item_archived")]
        ItemArchived,
        [EnumMember(Value = "item_deleted")]
        ItemDeleted,
        [EnumMember(Value = "item_moved_to_any_group")]
        ItemMovedToAnyGroup,
        [EnumMember(Value = "item_moved_to_specific_group")]
        ItemMovedToSpecificGroup,
        [EnumMember(Value = "item_restored")]
        ItemRestored,
        [EnumMember(Value = "move_subitem")]
        MoveSubitem,
        [EnumMember(Value = "subitem_archived")]
        SubitemArchived,
        [EnumMember(Value = "subitem_deleted")]
        SubitemDeleted
    }
}
