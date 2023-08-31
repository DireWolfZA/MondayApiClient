using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TeamQueryBuilder : GraphQlQueryBuilder<TeamQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "picture_url" },
            new GraphQlFieldMetadata { Name = "users", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName { get { return "Team"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public TeamQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public TeamQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public TeamQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public TeamQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public TeamQueryBuilder WithPictureUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("picture_url", alias, new GraphQlDirective[] { include, skip });
        }

        public TeamQueryBuilder ExceptPictureUrl() {
            return ExceptField("picture_url");
        }

        public TeamQueryBuilder WithUsers(UserQueryBuilder userQueryBuilder, QueryBuilderParameter<IEnumerable<int?>> ids = null, QueryBuilderParameter<UserKind?> kind = null, QueryBuilderParameter<bool?> newestFirst = null, QueryBuilderParameter<IEnumerable<string>> emails = null, QueryBuilderParameter<string> name = null, QueryBuilderParameter<bool?> nonActive = null, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
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

        public TeamQueryBuilder ExceptUsers() {
            return ExceptField("users");
        }
    }
}
