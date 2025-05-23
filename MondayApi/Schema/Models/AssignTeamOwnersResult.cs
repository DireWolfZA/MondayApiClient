using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AssignTeamOwnersResult {
        public Team? Team { get; set; }
        public ICollection<AssignTeamOwnersError>? Errors { get; set; }
    }
}
