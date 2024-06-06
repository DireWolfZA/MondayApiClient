using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FolderCustomIcon {
        [EnumMember(Value = "WORK")]
        Work,
        [EnumMember(Value = "MOREBELOW")]
        Morebelow,
        [EnumMember(Value = "MOREBELOWFILLED")]
        Morebelowfilled,
        [EnumMember(Value = "FOLDER")]
        Folder,
        [EnumMember(Value = "NULL")]
        Null
    }
}
