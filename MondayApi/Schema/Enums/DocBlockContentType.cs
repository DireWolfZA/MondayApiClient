using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DocBlockContentType {
        [EnumMember(Value = "bulleted_list")]
        BulletedList,
        [EnumMember(Value = "check_list")]
        CheckList,
        [EnumMember(Value = "code")]
        Code,
        [EnumMember(Value = "divider")]
        Divider,
        [EnumMember(Value = "image")]
        Image,
        [EnumMember(Value = "large_title")]
        LargeTitle,
        [EnumMember(Value = "layout")]
        Layout,
        [EnumMember(Value = "medium_title")]
        MediumTitle,
        [EnumMember(Value = "normal_text")]
        NormalText,
        [EnumMember(Value = "notice_box")]
        NoticeBox,
        [EnumMember(Value = "numbered_list")]
        NumberedList,
        [EnumMember(Value = "page_break")]
        PageBreak,
        [EnumMember(Value = "quote")]
        Quote,
        [EnumMember(Value = "small_title")]
        SmallTitle,
        [EnumMember(Value = "table")]
        Table,
        [EnumMember(Value = "video")]
        Video
    }
}
