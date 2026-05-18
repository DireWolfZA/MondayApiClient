using System.Collections.Generic;

namespace MondayApi.Schema {
    public class EventsExportQueryBuilder : GraphQlQueryBuilder<EventsExportQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "events", IsComplex = true, QueryBuilderType = typeof(EventQueryBuilder) },
            new GraphQlFieldMetadata { Name = "total" },
            new GraphQlFieldMetadata { Name = "limit" },
            new GraphQlFieldMetadata { Name = "offset" }
        };

        protected override string TypeName => "EventsExport";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public EventsExportQueryBuilder WithEvents(EventQueryBuilder eventQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("events", alias, eventQueryBuilder, new GraphQlDirective?[] { include, skip });
        public EventsExportQueryBuilder ExceptEvents() =>
            ExceptField("events");
        public EventsExportQueryBuilder WithTotal(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("total", alias, new GraphQlDirective?[] { include, skip });
        public EventsExportQueryBuilder ExceptTotal() =>
            ExceptField("total");
        public EventsExportQueryBuilder WithLimit(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("limit", alias, new GraphQlDirective?[] { include, skip });
        public EventsExportQueryBuilder ExceptLimit() =>
            ExceptField("limit");
        public EventsExportQueryBuilder WithOffset(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("offset", alias, new GraphQlDirective?[] { include, skip });
        public EventsExportQueryBuilder ExceptOffset() =>
            ExceptField("offset");
    }
}
