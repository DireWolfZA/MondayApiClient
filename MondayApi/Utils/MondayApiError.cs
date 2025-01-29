namespace MondayApi.Utils {
    [System.Diagnostics.DebuggerDisplay("{StatusCode}: {ErrorCode}: {ErrorMessage}")]
    public class MondayApiError {
        public string ErrorCode { get; set; }
        public int? StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public object ErrorData { get; set; }
        public string[] Errors { get; set; }
        public int? AccountID { get; set; }
    }
}
