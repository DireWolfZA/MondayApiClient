using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Query {
        public Account Account { get; set; }
        [JsonProperty("app_subscription")]
        public ICollection<AppSubscription> AppSubscription { get; set; }
        [JsonProperty("apps_monetization_status")]
        public AppMonetizationStatus AppsMonetizationStatus { get; set; }
        public ICollection<Asset> Assets { get; set; }
        public ICollection<Board> Boards { get; set; }
        public Complexity Complexity { get; set; }
        public ICollection<Document> Docs { get; set; }
        public ICollection<Folder> Folders { get; set; }
        public ICollection<Item> Items { get; set; }
        public User Me { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<Update> Updates { get; set; }
        public ICollection<User> Users { get; set; }
        public Version Version { get; set; }
        public ICollection<Version> Versions { get; set; }
        public ICollection<Webhook> Webhooks { get; set; }
        public ICollection<Workspace> Workspaces { get; set; }
    }
}
