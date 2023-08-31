using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardObjectType {
        [EnumMember(Value = "board")] Board,
        [EnumMember(Value = "sub_items_board")] SubItemsBoard,
        [EnumMember(Value = "document")] Document,
        [EnumMember(Value = "custom_object")] CustomObject
    }
}
