using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DuplicateBoardType {
        [EnumMember(Value = "duplicate_board_with_pulses")]
        DuplicateBoardWithPulses,
        [EnumMember(Value = "duplicate_board_with_pulses_and_updates")]
        DuplicateBoardWithPulsesAndUpdates,
        [EnumMember(Value = "duplicate_board_with_structure")]
        DuplicateBoardWithStructure
    }
}
