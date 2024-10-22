using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardObjectType {
        [EnumMember(Value = "board")]
        Board,
        [EnumMember(Value = "custom_object")]
        CustomObject,
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "sub_items_board")]
        SubItemsBoard
    }
}
