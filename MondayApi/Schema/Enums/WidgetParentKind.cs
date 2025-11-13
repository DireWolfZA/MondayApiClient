using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum WidgetParentKind {
        [EnumMember(Value = "DASHBOARD")]
        Dashboard,
        [EnumMember(Value = "BOARD_VIEW")]
        BoardView
    }
}
