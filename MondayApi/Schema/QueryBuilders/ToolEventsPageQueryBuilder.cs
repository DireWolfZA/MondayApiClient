using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ToolEventsPageQueryBuilder : GraphQlQueryBuilder<ToolEventsPageQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "tool_events", IsComplex = true, QueryBuilderType = typeof(ToolEventQueryBuilder) }
        };

        protected override string TypeName => "ToolEventsPage";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ToolEventsPageQueryBuilder WithToolEvents(ToolEventQueryBuilder toolEventQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("tool_events", alias, toolEventQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ToolEventsPageQueryBuilder ExceptToolEvents() =>
            ExceptField("tool_events");
    }
}
