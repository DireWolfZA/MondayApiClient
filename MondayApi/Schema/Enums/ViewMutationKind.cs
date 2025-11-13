using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ViewMutationKind {
        [EnumMember(Value = "CREATE")]
        Create,
        [EnumMember(Value = "UPDATE")]
        Update
    }
}
