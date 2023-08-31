using System.Collections.Generic;

namespace MondayApi.Schema {
    public class QueryQueryBuilder : GraphQlQueryBuilder<QueryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "account", IsComplex = true, QueryBuilderType = typeof(AccountQueryBuilder) },
            new GraphQlFieldMetadata { Name = "app_subscription", IsComplex = true, QueryBuilderType = typeof(AppSubscriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "apps_monetization_status", IsComplex = true, QueryBuilderType = typeof(AppMonetizationStatusQueryBuilder) },
            new GraphQlFieldMetadata { Name = "assets", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "boards", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "complexity", IsComplex = true, QueryBuilderType = typeof(ComplexityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "docs", IsComplex = true, QueryBuilderType = typeof(DocumentQueryBuilder) },
            new GraphQlFieldMetadata { Name = "folders", IsComplex = true, QueryBuilderType = typeof(FolderQueryBuilder) },
            new GraphQlFieldMetadata { Name = "items", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "me", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "tags", IsComplex = true, QueryBuilderType = typeof(TagQueryBuilder) },
            new GraphQlFieldMetadata { Name = "teams", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "updates", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "version", IsComplex = true, QueryBuilderType = typeof(VersionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "versions", IsComplex = true, QueryBuilderType = typeof(VersionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "webhooks", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(WebhookQueryBuilder) },
            new GraphQlFieldMetadata { Name = "workspaces", IsComplex = true, QueryBuilderType = typeof(WorkspaceQueryBuilder) }
        };

        protected override string TypeName { get { return "Query"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public QueryQueryBuilder(string operationName = null) : base("query", operationName) {
        }

        public QueryQueryBuilder WithParameter<T>(GraphQlQueryParameter<T> parameter) {
            return WithParameterInternal(parameter);
        }

        public QueryQueryBuilder WithAccount(AccountQueryBuilder accountQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("account", alias, accountQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public QueryQueryBuilder ExceptAccount() {
            return ExceptField("account");
        }

        public QueryQueryBuilder WithAppSubscription(AppSubscriptionQueryBuilder appSubscriptionQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("app_subscription", alias, appSubscriptionQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public QueryQueryBuilder ExceptAppSubscription() {
            return ExceptField("app_subscription");
        }

        public QueryQueryBuilder WithAppsMonetizationStatus(AppMonetizationStatusQueryBuilder appMonetizationStatusQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("apps_monetization_status", alias, appMonetizationStatusQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public QueryQueryBuilder ExceptAppsMonetizationStatus() {
            return ExceptField("apps_monetization_status");
        }

        public QueryQueryBuilder WithAssets(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<IEnumerable<int?>> ids, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("assets", alias, assetQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptAssets() {
            return ExceptField("assets");
        }

        public QueryQueryBuilder WithBoards(BoardQueryBuilder boardQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, QueryBuilderParameter<IEnumerable<int?>> ids = null, QueryBuilderParameter<BoardKind?> boardKind = null, QueryBuilderParameter<State?> state = null, QueryBuilderParameter<bool?> newestFirst = null, QueryBuilderParameter<BoardsOrderBy?> orderBy = null, QueryBuilderParameter<IEnumerable<int?>> workspaceIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            if (boardKind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_kind", ArgumentValue = boardKind });

            if (state != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "state", ArgumentValue = state });

            if (newestFirst != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "newest_first", ArgumentValue = newestFirst });

            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });

            if (workspaceIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIds });

            return WithObjectField("boards", alias, boardQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptBoards() {
            return ExceptField("boards");
        }

        public QueryQueryBuilder WithComplexity(ComplexityQueryBuilder complexityQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("complexity", alias, complexityQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public QueryQueryBuilder ExceptComplexity() {
            return ExceptField("complexity");
        }

        public QueryQueryBuilder WithDocs(DocumentQueryBuilder documentQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, QueryBuilderParameter<IEnumerable<int?>> ids = null, QueryBuilderParameter<IEnumerable<int?>> workspaceIds = null, QueryBuilderParameter<DocsOrderBy?> orderBy = null, QueryBuilderParameter<IEnumerable<int?>> objectIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            if (workspaceIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIds });

            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });

            if (objectIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "object_ids", ArgumentValue = objectIds });

            return WithObjectField("docs", alias, documentQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptDocs() {
            return ExceptField("docs");
        }

        public QueryQueryBuilder WithFolders(FolderQueryBuilder folderQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, QueryBuilderParameter<IEnumerable<int>> ids = null, QueryBuilderParameter<IEnumerable<int?>> workspaceIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            if (workspaceIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "workspace_ids", ArgumentValue = workspaceIds });

            return WithObjectField("folders", alias, folderQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptFolders() {
            return ExceptField("folders");
        }

        public QueryQueryBuilder WithItems(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, QueryBuilderParameter<IEnumerable<int?>> ids = null, QueryBuilderParameter<bool?> newestFirst = null, QueryBuilderParameter<bool?> excludeNonactive = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            if (newestFirst != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "newest_first", ArgumentValue = newestFirst });

            if (excludeNonactive != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "exclude_nonactive", ArgumentValue = excludeNonactive });

            return WithObjectField("items", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptItems() {
            return ExceptField("items");
        }

        public QueryQueryBuilder WithMe(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("me", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public QueryQueryBuilder ExceptMe() {
            return ExceptField("me");
        }

        public QueryQueryBuilder WithTags(TagQueryBuilder tagQueryBuilder, QueryBuilderParameter<IEnumerable<int?>> ids = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            return WithObjectField("tags", alias, tagQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptTags() {
            return ExceptField("tags");
        }

        public QueryQueryBuilder WithTeams(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<IEnumerable<int?>> ids = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            return WithObjectField("teams", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptTeams() {
            return ExceptField("teams");
        }

        public QueryQueryBuilder WithUpdates(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("updates", alias, updateQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptUpdates() {
            return ExceptField("updates");
        }

        public QueryQueryBuilder WithUsers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<int?>> ids = null, QueryBuilderParameter<UserKind?> kind = null, QueryBuilderParameter<bool?> newestFirst = null, QueryBuilderParameter<IEnumerable<string>> emails = null, QueryBuilderParameter<string> name = null, QueryBuilderParameter<bool?> nonActive = null, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });

            if (newestFirst != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "newest_first", ArgumentValue = newestFirst });

            if (emails != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "emails", ArgumentValue = emails });

            if (name != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "name", ArgumentValue = name });

            if (nonActive != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "non_active", ArgumentValue = nonActive });

            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("users", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptUsers() {
            return ExceptField("users");
        }

        public QueryQueryBuilder WithVersion(VersionQueryBuilder versionQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("version", alias, versionQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public QueryQueryBuilder ExceptVersion() {
            return ExceptField("version");
        }

        public QueryQueryBuilder WithVersions(VersionQueryBuilder versionQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("versions", alias, versionQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public QueryQueryBuilder ExceptVersions() {
            return ExceptField("versions");
        }

        public QueryQueryBuilder WithWebhooks(WebhookQueryBuilder webhookQueryBuilder, QueryBuilderParameter<int> boardId, QueryBuilderParameter<bool?> appWebhooksOnly = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "board_id", ArgumentValue = boardId });
            if (appWebhooksOnly != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "app_webhooks_only", ArgumentValue = appWebhooksOnly });

            return WithObjectField("webhooks", alias, webhookQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptWebhooks() {
            return ExceptField("webhooks");
        }

        public QueryQueryBuilder WithWorkspaces(WorkspaceQueryBuilder workspaceQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, QueryBuilderParameter<IEnumerable<int?>> ids = null, QueryBuilderParameter<WorkspaceKind?> kind = null, QueryBuilderParameter<State?> state = null, QueryBuilderParameter<WorkspacesOrderBy?> orderBy = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            if (kind != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "kind", ArgumentValue = kind });

            if (state != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "state", ArgumentValue = state });

            if (orderBy != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "order_by", ArgumentValue = orderBy });

            return WithObjectField("workspaces", alias, workspaceQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public QueryQueryBuilder ExceptWorkspaces() {
            return ExceptField("workspaces");
        }
    }
}
