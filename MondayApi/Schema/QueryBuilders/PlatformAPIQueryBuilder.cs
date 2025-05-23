using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PlatformAPIQueryBuilder : GraphQlQueryBuilder<PlatformAPIQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "daily_limit", IsComplex = true, QueryBuilderType = typeof(DailyLimitQueryBuilder) },
            new GraphQlFieldMetadata { Name = "daily_analytics", IsComplex = true, QueryBuilderType = typeof(DailyAnalyticsQueryBuilder) }
        };

        protected override string TypeName => "PlatformApi";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PlatformAPIQueryBuilder WithDailyLimit(DailyLimitQueryBuilder dailyLimitQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("daily_limit", alias, dailyLimitQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PlatformAPIQueryBuilder ExceptDailyLimit() =>
            ExceptField("daily_limit");
        public PlatformAPIQueryBuilder WithDailyAnalytics(DailyAnalyticsQueryBuilder dailyAnalyticsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("daily_analytics", alias, dailyAnalyticsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PlatformAPIQueryBuilder ExceptDailyAnalytics() =>
            ExceptField("daily_analytics");
    }
}
