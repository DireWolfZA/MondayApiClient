using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PlatformAPIDailyAnalyticsByAppQueryBuilder : GraphQlQueryBuilder<PlatformAPIDailyAnalyticsByAppQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "app", IsComplex = true, QueryBuilderType = typeof(AppTypeQueryBuilder) },
            new GraphQlFieldMetadata { Name = "usage" },
            new GraphQlFieldMetadata { Name = "api_app_id" }
        };

        protected override string TypeName => "PlatformApiDailyAnalyticsByApp";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PlatformAPIDailyAnalyticsByAppQueryBuilder WithApp(AppTypeQueryBuilder appTypeQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("app", alias, appTypeQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PlatformAPIDailyAnalyticsByAppQueryBuilder ExceptApp() =>
            ExceptField("app");
        public PlatformAPIDailyAnalyticsByAppQueryBuilder WithUsage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("usage", alias, new GraphQlDirective?[] { include, skip });
        public PlatformAPIDailyAnalyticsByAppQueryBuilder ExceptUsage() =>
            ExceptField("usage");
        public PlatformAPIDailyAnalyticsByAppQueryBuilder WithApiAppID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("api_app_id", alias, new GraphQlDirective?[] { include, skip });
        public PlatformAPIDailyAnalyticsByAppQueryBuilder ExceptApiAppID() =>
            ExceptField("api_app_id");
    }
}
