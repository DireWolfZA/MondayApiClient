using System.Runtime.Serialization;

namespace MondayApi.Schema {
    public enum DuplicateType {
        [EnumMember(Value = "duplicate_doc_with_content")]
        DuplicateDocWithContent,
        [EnumMember(Value = "duplicate_doc_with_content_and_updates")]
        DuplicateDocWithContentAndUpdates
    }
}
