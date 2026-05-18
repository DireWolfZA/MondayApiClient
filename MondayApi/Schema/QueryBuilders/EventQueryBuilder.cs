using System.Collections.Generic;

namespace MondayApi.Schema {
    public class EventQueryBuilder : GraphQlQueryBuilder<EventQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "board_id" },
            new GraphQlFieldMetadata { Name = "event_data" },
            new GraphQlFieldMetadata { Name = "origin_last_updated" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "Event";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public EventQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public EventQueryBuilder ExceptID() =>
            ExceptField("id");
        public EventQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public EventQueryBuilder ExceptType() =>
            ExceptField("type");
        public EventQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public EventQueryBuilder ExceptState() =>
            ExceptField("state");
        public EventQueryBuilder WithBoardID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("board_id", alias, new GraphQlDirective?[] { include, skip });
        public EventQueryBuilder ExceptBoardID() =>
            ExceptField("board_id");
        public EventQueryBuilder WithEventData(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("event_data", alias, new GraphQlDirective?[] { include, skip });
        public EventQueryBuilder ExceptEventData() =>
            ExceptField("event_data");
        public EventQueryBuilder WithOriginLastUpdated(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("origin_last_updated", alias, new GraphQlDirective?[] { include, skip });
        public EventQueryBuilder ExceptOriginLastUpdated() =>
            ExceptField("origin_last_updated");
        public EventQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public EventQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public EventQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public EventQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}
