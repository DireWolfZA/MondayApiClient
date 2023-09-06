using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TimeTrackingValueQueryBuilder : GraphQlQueryBuilder<TimeTrackingValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "duration" },
            new GraphQlFieldMetadata { Name = "history", IsComplex = true, QueryBuilderType = typeof(TimeTrackingHistoryItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "running" },
            new GraphQlFieldMetadata { Name = "started_at", IsComplex = true },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "TimeTrackingValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TimeTrackingValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public TimeTrackingValueQueryBuilder WithDuration(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("duration", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptDuration() =>
            ExceptField("duration");
        public TimeTrackingValueQueryBuilder WithHistory(TimeTrackingHistoryItemQueryBuilder timeTrackingHistoryItemQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("history", alias, timeTrackingHistoryItemQueryBuilder, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptHistory() =>
            ExceptField("history");
        public TimeTrackingValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public TimeTrackingValueQueryBuilder WithRunning(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("running", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptRunning() =>
            ExceptField("running");
        public TimeTrackingValueQueryBuilder WithStartedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("started_at", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptStartedAt() =>
            ExceptField("started_at");
        public TimeTrackingValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public TimeTrackingValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public TimeTrackingValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public TimeTrackingValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public TimeTrackingValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
