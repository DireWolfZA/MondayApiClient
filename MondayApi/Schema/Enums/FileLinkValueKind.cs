using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FileLinkValueKind {
        [EnumMember(Value = "box")]
        Box,
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
