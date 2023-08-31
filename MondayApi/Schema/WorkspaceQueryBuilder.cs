using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WorkspaceQueryBuilder : GraphQlQueryBuilder<WorkspaceQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "account_product", IsComplex = true, QueryBuilderType = typeof(AccountProductQueryBuilder) },
                new GraphQlFieldMetadata { Name = "created_at" },
                new GraphQlFieldMetadata { Name = "description" },
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "kind" },
                new GraphQlFieldMetadata { Name = "name" },
                new GraphQlFieldMetadata { Name = "owners_subscribers", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
                new GraphQlFieldMetadata { Name = "settings", IsComplex = true, QueryBuilderType = typeof(WorkspaceSettingsQueryBuilder) },
                new GraphQlFieldMetadata { Name = "state" },
                new GraphQlFieldMetadata { Name = "team_owners_subscribers", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
                new GraphQlFieldMetadata { Name = "teams_subscribers", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
                new GraphQlFieldMetadata { Name = "users_subscribers", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
            };

        protected override string TypeName { get { return "Workspace"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public WorkspaceQueryBuilder WithAccountProduct(AccountProductQueryBuilder accountProductQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("account_product", alias, accountProductQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceQueryBuilder ExceptAccountProduct() {
            return ExceptField("account_product");
        }

        public WorkspaceQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public WorkspaceQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceQueryBuilder ExceptDescription() {
            return ExceptField("description");
        }

        public WorkspaceQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public WorkspaceQueryBuilder WithKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("kind", alias, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceQueryBuilder ExceptKind() {
            return ExceptField("kind");
        }

        public WorkspaceQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public WorkspaceQueryBuilder WithOwnersSubscribers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("owners_subscribers", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public WorkspaceQueryBuilder ExceptOwnersSubscribers() {
            return ExceptField("owners_subscribers");
        }

        public WorkspaceQueryBuilder WithSettings(WorkspaceSettingsQueryBuilder workspaceSettingsQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("settings", alias, workspaceSettingsQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceQueryBuilder ExceptSettings() {
            return ExceptField("settings");
        }

        public WorkspaceQueryBuilder WithState(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("state", alias, new GraphQlDirective[] { include, skip });
        }

        public WorkspaceQueryBuilder ExceptState() {
            return ExceptField("state");
        }

        public WorkspaceQueryBuilder WithTeamOwnersSubscribers(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("team_owners_subscribers", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public WorkspaceQueryBuilder ExceptTeamOwnersSubscribers() {
            return ExceptField("team_owners_subscribers");
        }

        public WorkspaceQueryBuilder WithTeamsSubscribers(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("teams_subscribers", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public WorkspaceQueryBuilder ExceptTeamsSubscribers() {
            return ExceptField("teams_subscribers");
        }

        public WorkspaceQueryBuilder WithUsersSubscribers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("users_subscribers", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public WorkspaceQueryBuilder ExceptUsersSubscribers() {
            return ExceptField("users_subscribers");
        }
    }
}
