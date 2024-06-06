using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Query {
        public Account Account { get; set; }
        [JsonProperty("app_installs")]
        public ICollection<AppInstall> AppInstalls { get; set; }
        [JsonProperty("app_subscription")]
        public ICollection<AppSubscription> AppSubscription { get; set; }
        [JsonProperty("app_subscription_operations")]
        public AppSubscriptionOperationsCounter AppSubscriptionOperations { get; set; }
        [JsonProperty("apps_monetization_status")]
        public AppMonetizationStatus AppsMonetizationStatus { get; set; }
        public ICollection<Asset> Assets { get; set; }
        public ICollection<Board> Boards { get; set; }
        public Complexity Complexity { get; set; }
        public ICollection<Document> Docs { get; set; }
        public ICollection<Folder> Folders { get; set; }
        public ICollection<Item> Items { get; set; }
        [JsonProperty("items_page_by_column_values")]
        public ItemsResponse ItemsPageByColumnValues { get; set; }
        public User Me { get; set; }
        [JsonProperty("next_items_page")]
        public ItemsResponse NextItemsPage { get; set; }
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
