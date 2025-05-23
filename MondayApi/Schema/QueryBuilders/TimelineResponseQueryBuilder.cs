using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TimelineResponseQueryBuilder : GraphQlQueryBuilder<TimelineResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "timeline_items_page", IsComplex = true, QueryBuilderType = typeof(TimelineItemsPageQueryBuilder) }
        };

        protected override string TypeName => "TimelineResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TimelineResponseQueryBuilder WithTimelineItemsPage(TimelineItemsPageQueryBuilder timelineItemsPageQueryBuilder, QueryBuilderParameter<string?>? cursor = null, QueryBuilderParameter<int?>? limit = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (cursor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor });
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            return WithObjectField("timeline_items_page", alias, timelineItemsPageQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }

        public TimelineResponseQueryBuilder ExceptTimelineItemsPage() =>
            ExceptField("timeline_items_page");
    }
}
