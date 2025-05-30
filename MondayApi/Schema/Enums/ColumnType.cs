using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ColumnType {
        [EnumMember(Value = "auto_number")]
        AutoNumber,
        [EnumMember(Value = "board_relation")]
        BoardRelation,
        [EnumMember(Value = "button")]
        Button,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "color_picker")]
        ColorPicker,
        [EnumMember(Value = "country")]
        Country,
        [EnumMember(Value = "creation_log")]
        CreationLog,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "dependency")]
        Dependency,
        [EnumMember(Value = "direct_doc")]
        DirectDoc,
        [EnumMember(Value = "doc")]
        Doc,
        [EnumMember(Value = "dropdown")]
        Dropdown,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "formula")]
        Formula,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "hour")]
        Hour,
        [EnumMember(Value = "integration")]
        Integration,
        [EnumMember(Value = "item_assignees")]
        ItemAssignees,
        [EnumMember(Value = "item_id")]
        ItemID,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "location")]
        Location,
        [EnumMember(Value = "long_text")]
        LongText,
        [EnumMember(Value = "mirror")]
        Mirror,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "numbers")]
        Numbers,
        [EnumMember(Value = "people")]
        People,
        [EnumMember(Value = "person")]
        Person,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "progress")]
        Progress,
        [EnumMember(Value = "rating")]
        Rating,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "subtasks")]
        Subtasks,
        [EnumMember(Value = "tags")]
        Tags,
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "time_tracking")]
        TimeTracking,
        [EnumMember(Value = "timeline")]
        Timeline,
        [EnumMember(Value = "unsupported")]
        Unsupported,
        [EnumMember(Value = "vote")]
        Vote,
        [EnumMember(Value = "week")]
        Week,
        [EnumMember(Value = "world_clock")]
        WorldClock
    }
}
