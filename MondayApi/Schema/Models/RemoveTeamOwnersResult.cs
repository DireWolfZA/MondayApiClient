using System.Collections.Generic;

namespace MondayApi.Schema {
    public class RemoveTeamOwnersResult {
        public Team? Team { get; set; }
        public ICollection<RemoveTeamOwnersError>? Errors { get; set; }
    }
}
