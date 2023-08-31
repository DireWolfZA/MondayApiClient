using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum AssetsSource {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "columns")]
        Columns,
        [EnumMember(Value = "gallery")]
        Gallery
    }
}
