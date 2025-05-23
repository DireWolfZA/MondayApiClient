namespace MondayApi.Schema {
    public class InviteUsersError {
        public string? Message { get; set; }
        public InviteUsersErrorCode? Code { get; set; }
        public string? Email { get; set; }
    }
}
