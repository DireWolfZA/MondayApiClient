namespace MondayApi.Schema {
    public class PrefillSettings {
        public bool? Enabled { get; set; }
        public FormQuestionPrefillSources? Source { get; set; }
        public string? Lookup { get; set; }
    }
}
