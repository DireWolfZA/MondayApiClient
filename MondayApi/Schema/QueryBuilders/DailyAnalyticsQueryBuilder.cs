using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DailyAnalyticsQueryBuilder : GraphQlQueryBuilder<DailyAnalyticsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "last_updated" },
            new GraphQlFieldMetadata { Name = "by_day", IsComplex = true, QueryBuilderType = typeof(PlatformAPIDailyAnalyticsByDayQueryBuilder) },
            new GraphQlFieldMetadata { Name = "by_app", IsComplex = true, QueryBuilderType = typeof(PlatformAPIDailyAnalyticsByAppQueryBuilder) },
            new GraphQlFieldMetadata { Name = "by_user", IsComplex = true, QueryBuilderType = typeof(PlatformAPIDailyAnalyticsByUserQueryBuilder) }
        };

        protected override string TypeName => "DailyAnalytics";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DailyAnalyticsQueryBuilder WithLastUpdated(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("last_updated", alias, new GraphQlDirective?[] { include, skip });
        public DailyAnalyticsQueryBuilder ExceptLastUpdated() =>
            ExceptField("last_updated");
        public DailyAnalyticsQueryBuilder WithByDay(PlatformAPIDailyAnalyticsByDayQueryBuilder platformApiDailyAnalyticsByDayQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("by_day", alias, platformApiDailyAnalyticsByDayQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DailyAnalyticsQueryBuilder ExceptByDay() =>
            ExceptField("by_day");
        public DailyAnalyticsQueryBuilder WithByApp(PlatformAPIDailyAnalyticsByAppQueryBuilder platformApiDailyAnalyticsByAppQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("by_app", alias, platformApiDailyAnalyticsByAppQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DailyAnalyticsQueryBuilder ExceptByApp() =>
            ExceptField("by_app");
        public DailyAnalyticsQueryBuilder WithByUser(PlatformAPIDailyAnalyticsByUserQueryBuilder platformApiDailyAnalyticsByUserQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("by_user", alias, platformApiDailyAnalyticsByUserQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DailyAnalyticsQueryBuilder ExceptByUser() =>
            ExceptField("by_user");
    }
}
