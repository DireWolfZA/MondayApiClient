using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TeamQueryBuilder : GraphQlQueryBuilder<TeamQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "owners", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "picture_url" },
            new GraphQlFieldMetadata { Name = "users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "is_guest" }
        };

        protected override string TypeName => "Team";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TeamQueryBuilder WithOwners(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<string>> ids = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            return WithObjectField("owners", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }
        public TeamQueryBuilder WithUsers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<string>> emails = null, QueryBuilderParameter<IEnumerable<string>> ids = null, QueryBuilderParameter<UserKind> kind = null, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<string> name = null, QueryBuilderParameter<bool?> newestFirst = null, QueryBuilderParameter<bool?> nonActive = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
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

            return WithObjectField("users", alias, userQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public TeamQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public TeamQueryBuilder ExceptID() =>
            ExceptField("id");
        public TeamQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        public TeamQueryBuilder ExceptName() =>
            ExceptField("name");
        public TeamQueryBuilder ExceptOwners() =>
            ExceptField("owners");
        public TeamQueryBuilder WithPictureURL(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("picture_url", alias, new GraphQlDirective[] { include, skip });
        public TeamQueryBuilder ExceptPictureURL() =>
            ExceptField("picture_url");
        public TeamQueryBuilder ExceptUsers() =>
            ExceptField("users");
        public TeamQueryBuilder WithIsGuest(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("is_guest", alias, new GraphQlDirective[] { include, skip });
        public TeamQueryBuilder ExceptIsGuest() =>
            ExceptField("is_guest");
    }
}
