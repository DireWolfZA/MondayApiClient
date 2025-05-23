using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PlatformAPIDailyAnalyticsByDayQueryBuilder : GraphQlQueryBuilder<PlatformAPIDailyAnalyticsByDayQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "day" },
            new GraphQlFieldMetadata { Name = "usage" }
        };

        protected override string TypeName => "PlatformApiDailyAnalyticsByDay";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PlatformAPIDailyAnalyticsByDayQueryBuilder WithDay(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("day", alias, new GraphQlDirective?[] { include, skip });
        public PlatformAPIDailyAnalyticsByDayQueryBuilder ExceptDay() =>
            ExceptField("day");
        public PlatformAPIDailyAnalyticsByDayQueryBuilder WithUsage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("usage", alias, new GraphQlDirective?[] { include, skip });
        public PlatformAPIDailyAnalyticsByDayQueryBuilder ExceptUsage() =>
            ExceptField("usage");
    }
}
