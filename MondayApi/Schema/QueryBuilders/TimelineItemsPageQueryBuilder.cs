using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TimelineItemsPageQueryBuilder : GraphQlQueryBuilder<TimelineItemsPageQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "timeline_items", IsComplex = true, QueryBuilderType = typeof(TimelineItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "cursor" }
        };

        protected override string TypeName => "TimelineItemsPage";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TimelineItemsPageQueryBuilder WithTimelineItems(TimelineItemQueryBuilder timelineItemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("timeline_items", alias, timelineItemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TimelineItemsPageQueryBuilder ExceptTimelineItems() =>
            ExceptField("timeline_items");
        public TimelineItemsPageQueryBuilder WithCursor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("cursor", alias, new GraphQlDirective?[] { include, skip });
        public TimelineItemsPageQueryBuilder ExceptCursor() =>
            ExceptField("cursor");
    }
}
