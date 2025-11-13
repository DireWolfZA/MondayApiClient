using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardAccessLevel {
        [EnumMember(Value = "edit")]
        Edit,
        [EnumMember(Value = "view")]
        View
    }
}
