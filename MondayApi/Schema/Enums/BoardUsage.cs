using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum BoardUsage {
        [EnumMember(Value = "CONVERT_TO_PROJECT")]
        ConvertToProject,
        [EnumMember(Value = "CONNECT_TO_PORTFOLIO")]
        ConnectToPortfolio
    }
}
