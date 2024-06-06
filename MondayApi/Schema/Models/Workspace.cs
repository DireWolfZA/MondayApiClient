using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Workspace {
        [JsonProperty("account_product")]
        public AccountProduct AccountProduct { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        [JsonProperty("is_default_workspace")]
        public bool? IsDefaultWorkspace { get; set; }
        public WorkspaceKind? Kind { get; set; }
        public string Name { get; set; }
        [JsonProperty("owners_subscribers")]
        public ICollection<User> OwnersSubscribers { get; set; }
        public WorkspaceSettings Settings { get; set; }
        public State? State { get; set; }
        [JsonProperty("team_owners_subscribers")]
        public ICollection<Team> TeamOwnersSubscribers { get; set; }
        [JsonProperty("teams_subscribers")]
        public ICollection<Team> TeamsSubscribers { get; set; }
        [JsonProperty("users_subscribers")]
        public ICollection<User> UsersSubscribers { get; set; }
    }
}
