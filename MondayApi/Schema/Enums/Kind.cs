using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum Kind {
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "person")]
        Person
    }
}
