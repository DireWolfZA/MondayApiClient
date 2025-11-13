namespace MondayApi.Schema {
    public class FormPreSubmissionView {
        public bool? Enabled { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public FormStartButton? StartButton { get; set; }
    }
}
