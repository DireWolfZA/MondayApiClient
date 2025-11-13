namespace MondayApi.Schema {
    public class FormAppearance {
        public bool? HideBranding { get; set; }
        public bool? ShowProgressBar { get; set; }
        public string? PrimaryColor { get; set; }
        public FormLayout? Layout { get; set; }
        public FormBackground? Background { get; set; }
        public FormText? Text { get; set; }
        public FormLogo? Logo { get; set; }
        public FormSubmitButton? SubmitButton { get; set; }
    }
}
