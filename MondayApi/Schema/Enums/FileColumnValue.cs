using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FileColumnValue {
        [EnumMember(Value = "asset")]
        Asset,
        [EnumMember(Value = "box")]
        Box,
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "dropbox")]
        Dropbox,
        [EnumMember(Value = "google_drive")]
        GoogleDrive,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "onedrive")]
        OneDrive
    }
}
