namespace MondayApi.Schema {
    [System.Diagnostics.DebuggerDisplay("{ID}: {Kind}")]
    public class PeopleEntity {
        public string? ID { get; set; }
        public Kind? Kind { get; set; }
    }
}
