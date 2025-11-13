namespace MondayApi.Schema {
    public class FormAfterSubmissionView {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public FormRedirectAfterSubmission? RedirectAfterSubmission { get; set; }
        public bool? AllowResubmit { get; set; }
        public bool? ShowSuccessImage { get; set; }
        public bool? AllowEditSubmission { get; set; }
        public bool? AllowViewSubmission { get; set; }
    }
}
