using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WorkspaceQueryBuilder : GraphQlQueryBuilder<WorkspaceQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
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

        protected override string TypeName => "Workspace";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WorkspaceQueryBuilder WithOwnersSubscribers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("owners_subscribers", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public WorkspaceQueryBuilder WithTeamOwnersSubscribers(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("team_owners_subscribers", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public WorkspaceQueryBuilder WithTeamsSubscribers(TeamQueryBuilder teamQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("teams_subscribers", alias, teamQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public WorkspaceQueryBuilder WithUsersSubscribers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("users_subscribers", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public WorkspaceQueryBuilder WithAccountProduct(AccountProductQueryBuilder accountProductQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("account_product", alias, accountProductQueryBuilder, new GraphQlDirective[] { include, skip });
        public WorkspaceQueryBuilder ExceptAccountProduct() =>
            ExceptField("account_product");
        public WorkspaceQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public WorkspaceQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public WorkspaceQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        public WorkspaceQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public WorkspaceQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public WorkspaceQueryBuilder ExceptID() =>
            ExceptField("id");
        public WorkspaceQueryBuilder WithKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective[] { include, skip });
        public WorkspaceQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public WorkspaceQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        public WorkspaceQueryBuilder ExceptName() =>
            ExceptField("name");
        public WorkspaceQueryBuilder ExceptOwnersSubscribers() =>
            ExceptField("owners_subscribers");
        public WorkspaceQueryBuilder WithSettings(WorkspaceSettingsQueryBuilder workspaceSettingsQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("settings", alias, workspaceSettingsQueryBuilder, new GraphQlDirective[] { include, skip });
        public WorkspaceQueryBuilder ExceptSettings() =>
            ExceptField("settings");
        public WorkspaceQueryBuilder WithState(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective[] { include, skip });
        public WorkspaceQueryBuilder ExceptState() =>
            ExceptField("state");
        public WorkspaceQueryBuilder ExceptTeamOwnersSubscribers() =>
            ExceptField("team_owners_subscribers");
        public WorkspaceQueryBuilder ExceptTeamsSubscribers() =>
            ExceptField("teams_subscribers");
        public WorkspaceQueryBuilder ExceptUsersSubscribers() =>
            ExceptField("users_subscribers");
    }
}
