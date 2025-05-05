using System.Collections.Generic;

namespace MondayApi.Schema {
    public class QueryQueryBuilder : GraphQlQueryBuilder<QueryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "updates", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "custom_activity", IsComplex = true, QueryBuilderType = typeof(CustomActivityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "timeline_item", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(TimelineItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "marketplace_app_discounts", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(MarketplaceAppDiscountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "account", IsComplex = true, QueryBuilderType = typeof(AccountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_installs", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AppInstallQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_subscription", IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_subscription_operations", IsComplex = true, QueryBuilderType = typeof(AppSubscriptionOperationsCounterQueryBuilder) },
            new GraphQlFieldMetadata { Name = "apps_monetization_info", IsComplex = true, QueryBuilderType = typeof(AppsMonetizationInfoQueryBuilder) },
            new GraphQlFieldMetadata { Name = "apps_monetization_status", IsComplex = true, QueryBuilderType = typeof(AppMonetizationStatusQueryBuilder) },
            new GraphQlFieldMetadata { Name = "assets", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "boards", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "complexity", IsComplex = true, QueryBuilderType = typeof(ComplexityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "docs", IsComplex = true, QueryBuilderType = typeof(DocumentQueryBuilder) },
            new GraphQlFieldMetadata { Name = "folders", IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "items", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "items_page_by_column_values", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemsResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "me", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "next_items_page", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemsResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "tags", IsComplex = true, QueryBuilderType = typeof(TagQueryBuilder) },
            new GraphQlFieldMetadata { Name = "teams", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "version", IsComplex = true, QueryBuilderType = typeof(VersionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "versions", IsComplex = true, QueryBuilderType = typeof(VersionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "webhooks", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WebhookQueryBuilder) },
            new GraphQlFieldMetadata { Name = "workspaces", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) }
        };

        protected override string TypeName => "Query";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public QueryQueryBuilder WithUpdates(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("updates", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithTimelineItem(TimelineItemQueryBuilder timelineItemQueryBuilder, QueryBuilderParameter<string> id, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "id", ArgumentValue = id }
            };
            return WithObjectField("timeline_item", alias, timelineItemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithMarketplaceAppDiscounts(MarketplaceAppDiscountQueryBuilder marketplaceAppDiscountQueryBuilder, QueryBuilderParameter<string> appID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID }
            };
            return WithObjectField("marketplace_app_discounts", alias, marketplaceAppDiscountQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithAppInstalls(AppInstallQueryBuilder appInstallQueryBuilder, QueryBuilderParameter<string> appID, QueryBuilderParameter<string?>? accountID = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "app_id", ArgumentValue = appID }
            };
            if (accountID != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "account_id", ArgumentValue = accountID });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("app_installs", alias, appInstallQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithAppSubscriptionOperations(AppSubscriptionOperationsCounterQueryBuilder appSubscriptionOperationsCounterQueryBuilder, QueryBuilderParameter<string?>? kind = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            return WithObjectField("app_subscription_operations", alias, appSubscriptionOperationsCounterQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithAssets(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<IEnumerable<string>> ids, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids }
            };
            return WithObjectField("assets", alias, assetQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithBoards(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<BoardKind?>? boardKind = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<bool?>? latest = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<BoardsOrderBy?>? orderBy = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<State?>? state = null, QueryBuilderParameter<IEnumerable<string?>>? workspaceIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (boardKind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_kind", ArgumentValue = boardKind });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (latest != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "latest", ArgumentValue = latest });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (state != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "state", ArgumentValue = state });
            if (workspaceIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIDs });
            return WithObjectField("boards", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithDocs(DocumentQueryBuilder documentQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<IEnumerable<string>>? objectIDs = null, QueryBuilderParameter<DocsOrderBy?>? orderBy = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<IEnumerable<string?>>? workspaceIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (objectIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "object_ids", ArgumentValue = objectIDs });
            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (workspaceIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIDs });
            return WithObjectField("docs", alias, documentQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithFolders(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<IEnumerable<string?>>? workspaceIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (workspaceIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIDs });
            return WithObjectField("folders", alias, folderQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithItems(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<bool?>? excludeNonactive = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<bool?>? newestFirst = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (excludeNonactive != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "exclude_nonactive", ArgumentValue = excludeNonactive });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (newestFirst != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "newest_first", ArgumentValue = newestFirst });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("items", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithItemsPageByColumnValues(ItemsResponseQueryBuilder itemsResponseQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<int> limit, QueryBuilderParameter<IEnumerable<ItemsPageByColumnValuesQuery>>? columns = null, QueryBuilderParameter<string?>? cursor = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID },
                new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit }
            };
            if (columns != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "columns", ArgumentValue = columns });
            if (cursor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor });
            return WithObjectField("items_page_by_column_values", alias, itemsResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithNextItemsPage(ItemsResponseQueryBuilder itemsResponseQueryBuilder, QueryBuilderParameter<string> cursor, QueryBuilderParameter<int> limit, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor },
                new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit }
            };
            return WithObjectField("next_items_page", alias, itemsResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithTags(TagQueryBuilder tagQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("tags", alias, tagQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithTeams(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("teams", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithUsers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<string?>>? emails = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<UserKind?>? kind = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<string?>? name = null, QueryBuilderParameter<bool?>? newestFirst = null, QueryBuilderParameter<bool?>? nonActive = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (emails != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "emails", ArgumentValue = emails });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });
            if (newestFirst != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "newest_first", ArgumentValue = newestFirst });
            if (nonActive != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "non_active", ArgumentValue = nonActive });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("users", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithWebhooks(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<string> boardID, QueryBuilderParameter<bool?>? appWebhooksOnly = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo> {
                new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardID }
            };
            if (appWebhooksOnly != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "app_webhooks_only", ArgumentValue = appWebhooksOnly });
            return WithObjectField("webhooks", alias, webhookQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public QueryQueryBuilder WithWorkspaces(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<WorkspaceKind?>? kind = null, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<WorkspacesOrderBy?>? orderBy = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<State?>? state = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (state != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "state", ArgumentValue = state });
            return WithObjectField("workspaces", alias, workspaceQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }

        public QueryQueryBuilder(string? operationName = null) : base("query", operationName) { }
        public QueryQueryBuilder WithParameter<T>(GraphQlQueryParameter<T> parameter) =>
            WithParameterInternal(parameter);
        public QueryQueryBuilder ExceptUpdates() =>
            ExceptField("updates");
        public QueryQueryBuilder WithCustomActivity(CustomActivityQueryBuilder customActivityQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("custom_activity", alias, customActivityQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptCustomActivity() =>
            ExceptField("custom_activity");
        public QueryQueryBuilder ExceptTimelineItem() =>
            ExceptField("timeline_item");
        public QueryQueryBuilder ExceptMarketplaceAppDiscounts() =>
            ExceptField("marketplace_app_discounts");
        public QueryQueryBuilder WithAccount(AccountQueryBuilder accountQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("account", alias, accountQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAccount() =>
            ExceptField("account");
        public QueryQueryBuilder ExceptAppInstalls() =>
            ExceptField("app_installs");
        public QueryQueryBuilder WithAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAppSubscription() =>
            ExceptField("app_subscription");
        public QueryQueryBuilder ExceptAppSubscriptionOperations() =>
            ExceptField("app_subscription_operations");
        public QueryQueryBuilder WithAppsMonetizationInfo(AppsMonetizationInfoQueryBuilder appsMonetizationInfoQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("apps_monetization_info", alias, appsMonetizationInfoQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAppsMonetizationInfo() =>
            ExceptField("apps_monetization_info");
        public QueryQueryBuilder WithAppsMonetizationStatus(AppMonetizationStatusQueryBuilder appMonetizationStatusQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("apps_monetization_status", alias, appMonetizationStatusQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptAppsMonetizationStatus() =>
            ExceptField("apps_monetization_status");
        public QueryQueryBuilder ExceptAssets() =>
            ExceptField("assets");
        public QueryQueryBuilder ExceptBoards() =>
            ExceptField("boards");
        public QueryQueryBuilder WithComplexity(ComplexityQueryBuilder complexityQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("complexity", alias, complexityQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptComplexity() =>
            ExceptField("complexity");
        public QueryQueryBuilder ExceptDocs() =>
            ExceptField("docs");
        public QueryQueryBuilder ExceptFolders() =>
            ExceptField("folders");
        public QueryQueryBuilder ExceptItems() =>
            ExceptField("items");
        public QueryQueryBuilder ExceptItemsPageByColumnValues() =>
            ExceptField("items_page_by_column_values");
        public QueryQueryBuilder WithMe(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("me", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptMe() =>
            ExceptField("me");
        public QueryQueryBuilder ExceptNextItemsPage() =>
            ExceptField("next_items_page");
        public QueryQueryBuilder ExceptTags() =>
            ExceptField("tags");
        public QueryQueryBuilder ExceptTeams() =>
            ExceptField("teams");
        public QueryQueryBuilder ExceptUsers() =>
            ExceptField("users");
        public QueryQueryBuilder WithVersion(VersionQueryBuilder versionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("version", alias, versionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptVersion() =>
            ExceptField("version");
        public QueryQueryBuilder WithVersions(VersionQueryBuilder versionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("versions", alias, versionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public QueryQueryBuilder ExceptVersions() =>
            ExceptField("versions");
        public QueryQueryBuilder ExceptWebhooks() =>
            ExceptField("webhooks");
        public QueryQueryBuilder ExceptWorkspaces() =>
            ExceptField("workspaces");
    }
}
