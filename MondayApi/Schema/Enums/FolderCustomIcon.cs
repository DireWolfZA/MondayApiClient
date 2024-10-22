using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FolderCustomIcon {
        [EnumMember(Value = "FOLDER")]
        Folder,
        [EnumMember(Value = "MOREBELOW")]
        Morebelow,
        [EnumMember(Value = "MOREBELOWFILLED")]
        Morebelowfilled,
        [EnumMember(Value = "NULL")]
        Null,
        [EnumMember(Value = "WORK")]
        Work
    }
}
