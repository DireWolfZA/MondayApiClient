using System.Collections.Generic;
using Newtonsoft.Json;

namespace MondayApi.Schema {
    public class Query {
        public BlocksResult? Blocks { get; set; }
        [JsonProperty("remote_options")]
        public RemoteOptionsResponse? RemoteOptions { get; set; }
        public ICollection<Update>? Updates { get; set; }
        [JsonProperty("custom_activity")]
        public ICollection<CustomActivity>? CustomActivity { get; set; }
        [JsonProperty("timeline_item")]
        public TimelineItem? TimelineItem { get; set; }
        public TimelineResponse? Timeline { get; set; }
        [JsonProperty("managed_column")]
        public ICollection<ManagedColumn>? ManagedColumn { get; set; }
        [JsonProperty("marketplace_app_discounts")]
        public ICollection<MarketplaceAppDiscount>? MarketplaceAppDiscounts { get; set; }
        [JsonProperty("app_subscriptions")]
        public AppSubscriptions? AppSubscriptions { get; set; }
        public AppType? App { get; set; }
        public Account? Account { get; set; }
        [JsonProperty("app_installs")]
        public ICollection<AppInstall?>? AppInstalls { get; set; }
        [JsonProperty("app_subscription")]
        public ICollection<AppSubscription?>? AppSubscription { get; set; }
        [JsonProperty("app_subscription_operations")]
        public AppSubscriptionOperationsCounter? AppSubscriptionOperations { get; set; }
        [JsonProperty("apps_monetization_info")]
        public AppsMonetizationInfo? AppsMonetizationInfo { get; set; }
        [JsonProperty("apps_monetization_status")]
        public AppMonetizationStatus? AppsMonetizationStatus { get; set; }
        public ICollection<Asset?>? Assets { get; set; }
        public ICollection<Board?>? Boards { get; set; }
        public Complexity? Complexity { get; set; }
        public ICollection<Document?>? Docs { get; set; }
        public ICollection<Folder?>? Folders { get; set; }
        public ICollection<Item?>? Items { get; set; }
        [JsonProperty("items_page_by_column_values")]
        public ItemsResponse? ItemsPageByColumnValues { get; set; }
        public User? Me { get; set; }
        [JsonProperty("next_items_page")]
        public ItemsResponse? NextItemsPage { get; set; }
        public ICollection<Tag?>? Tags { get; set; }
        public ICollection<Team?>? Teams { get; set; }
        public ICollection<User?>? Users { get; set; }
        public ICollection<Webhook?>? Webhooks { get; set; }
        public ICollection<Workspace?>? Workspaces { get; set; }
        public Version? Version { get; set; }
        public ICollection<Version>? Versions { get; set; }
        [JsonProperty("platform_api")]
        public PlatformAPI? PlatformAPI { get; set; }
        [JsonProperty("account_roles")]
        public ICollection<AccountRole>? AccountRoles { get; set; }
    }
}
