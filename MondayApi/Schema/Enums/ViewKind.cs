using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum ViewKind {
        [EnumMember(Value = "DASHBOARD")]
        Dashboard,
        [EnumMember(Value = "TABLE")]
        Table,
        [EnumMember(Value = "FORM")]
        Form,
        [EnumMember(Value = "APP")]
        App
    }
}
