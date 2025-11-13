namespace MondayApi.Schema {
    public class FormFeatures {
        public bool? IsInternal { get; set; }
        public bool? ReCaptchaChallenge { get; set; }
        public FormShortenedLink? ShortenedLink { get; set; }
        public FormPassword? Password { get; set; }
        public FormDraftSubmission? DraftSubmission { get; set; }
        public FormRequireLogin? RequireLogin { get; set; }
        public FormResponseLimit? ResponseLimit { get; set; }
        public FormCloseDate? CloseDate { get; set; }
        public FormPreSubmissionView? PreSubmissionView { get; set; }
        public FormAfterSubmissionView? AfterSubmissionView { get; set; }
        public FormMonday? Monday { get; set; }
    }
}
