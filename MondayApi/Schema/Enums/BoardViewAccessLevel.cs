using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardViewAccessLevel {
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "edit")]
        Edit
    }
}
