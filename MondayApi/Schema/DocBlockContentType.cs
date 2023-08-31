using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DocBlockContentType {
        [EnumMember(Value = "normal_text")] NormalText,
        [EnumMember(Value = "large_title")] LargeTitle,
        [EnumMember(Value = "medium_title")] MediumTitle,
        [EnumMember(Value = "small_title")] SmallTitle,
        [EnumMember(Value = "quote")] Quote,
        [EnumMember(Value = "divider")] Divider,
        [EnumMember(Value = "bulleted_list")] BulletedList,
        [EnumMember(Value = "numbered_list")] NumberedList,
        [EnumMember(Value = "check_list")] CheckList,
        [EnumMember(Value = "image")] Image,
        [EnumMember(Value = "video")] Video,
        [EnumMember(Value = "table")] Table,
        [EnumMember(Value = "layout")] Layout,
        [EnumMember(Value = "code")] Code,
        [EnumMember(Value = "notice_box")] NoticeBox
    }
}
