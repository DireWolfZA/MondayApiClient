using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WatcherQueryBuilder : GraphQlQueryBuilder<WatcherQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "user_id" },
            new GraphQlFieldMetadata { Name = "medium" },
            new GraphQlFieldMetadata { Name = "user", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "Watcher";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WatcherQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public WatcherQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
        public WatcherQueryBuilder WithMedium(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("medium", alias, new GraphQlDirective?[] { include, skip });
        public WatcherQueryBuilder ExceptMedium() =>
            ExceptField("medium");
        public WatcherQueryBuilder WithUser(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("user", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public WatcherQueryBuilder ExceptUser() =>
            ExceptField("user");
    }
}
