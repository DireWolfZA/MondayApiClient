using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SprintTimelineQueryBuilder : GraphQlQueryBuilder<SprintTimelineQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "from" },
            new GraphQlFieldMetadata { Name = "to" }
        };

        protected override string TypeName => "SprintTimeline";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SprintTimelineQueryBuilder WithFrom(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("from", alias, new GraphQlDirective?[] { include, skip });
        public SprintTimelineQueryBuilder ExceptFrom() =>
            ExceptField("from");
        public SprintTimelineQueryBuilder WithTo(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("to", alias, new GraphQlDirective?[] { include, skip });
        public SprintTimelineQueryBuilder ExceptTo() =>
            ExceptField("to");
    }
}
