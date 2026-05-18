using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum Kind {
        [EnumMember(Value = "agent")]
        Agent,
        [EnumMember(Value = "person")]
        Person,
        [EnumMember(Value = "team")]
        Team
    }
}
