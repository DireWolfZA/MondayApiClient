using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PlatformAPIDailyAnalyticsByUserQueryBuilder : GraphQlQueryBuilder<PlatformAPIDailyAnalyticsByUserQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "user", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "usage" }
        };

        protected override string TypeName => "PlatformApiDailyAnalyticsByUser";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PlatformAPIDailyAnalyticsByUserQueryBuilder WithUser(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("user", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PlatformAPIDailyAnalyticsByUserQueryBuilder ExceptUser() =>
            ExceptField("user");
        public PlatformAPIDailyAnalyticsByUserQueryBuilder WithUsage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("usage", alias, new GraphQlDirective?[] { include, skip });
        public PlatformAPIDailyAnalyticsByUserQueryBuilder ExceptUsage() =>
            ExceptField("usage");
    }
}
