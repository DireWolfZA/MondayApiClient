using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum FileLinkValueKind {
        [EnumMember(Value = "google_drive")]
        GoogleDrive,
        [EnumMember(Value = "dropbox")]
        Dropbox,
        [EnumMember(Value = "box")]
        Box,
        [EnumMember(Value = "onedrive")]
        OneDrive,
        [EnumMember(Value = "link")]
        Link
    }
}
