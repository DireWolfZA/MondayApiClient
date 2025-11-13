using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SprintQueryBuilder : GraphQlQueryBuilder<SprintQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "items", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "start_date" },
            new GraphQlFieldMetadata { Name = "end_date" },
            new GraphQlFieldMetadata { Name = "timeline", IsComplex = true, QueryBuilderType = typeof(SprintTimelineQueryBuilder) },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "snapshots", IsComplex = true, QueryBuilderType = typeof(SprintSnapshotQueryBuilder) }
        };

        protected override string TypeName => "Sprint";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SprintQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SprintQueryBuilder ExceptID() =>
            ExceptField("id");
        public SprintQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public SprintQueryBuilder ExceptName() =>
            ExceptField("name");
        public SprintQueryBuilder WithItems(ItemQueryBuilder itemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("items", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SprintQueryBuilder ExceptItems() =>
            ExceptField("items");
        public SprintQueryBuilder WithStartDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("start_date", alias, new GraphQlDirective?[] { include, skip });
        public SprintQueryBuilder ExceptStartDate() =>
            ExceptField("start_date");
        public SprintQueryBuilder WithEndDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("end_date", alias, new GraphQlDirective?[] { include, skip });
        public SprintQueryBuilder ExceptEndDate() =>
            ExceptField("end_date");
        public SprintQueryBuilder WithTimeline(SprintTimelineQueryBuilder sprintTimelineQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("timeline", alias, sprintTimelineQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SprintQueryBuilder ExceptTimeline() =>
            ExceptField("timeline");
        public SprintQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public SprintQueryBuilder ExceptState() =>
            ExceptField("state");
        public SprintQueryBuilder WithSnapshots(SprintSnapshotQueryBuilder sprintSnapshotQueryBuilder, QueryBuilderParameter<IEnumerable<SprintSnapshotKind>>? type = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (type != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "type", ArgumentValue = type });
            return WithObjectField("snapshots", alias, sprintSnapshotQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public SprintQueryBuilder ExceptSnapshots() =>
            ExceptField("snapshots");
    }
}
