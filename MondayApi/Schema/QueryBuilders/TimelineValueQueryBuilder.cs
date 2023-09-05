using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TimelineValueQueryBuilder : GraphQlQueryBuilder<TimelineValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "from" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "to" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true },
            new GraphQlFieldMetadata { Name = "visualization_type" }
        };

        protected override string TypeName => "TimelineValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TimelineValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public TimelineValueQueryBuilder WithFrom(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("from", alias, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptFrom() =>
            ExceptField("from");
        public TimelineValueQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptId() =>
            ExceptField("id");
        public TimelineValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public TimelineValueQueryBuilder WithTo(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("to", alias, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptTo() =>
            ExceptField("to");
        public TimelineValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public TimelineValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public TimelineValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptValue() =>
            ExceptField("value");
        public TimelineValueQueryBuilder WithVisualizationType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("visualization_type", alias, new GraphQlDirective[] { include, skip });
        public TimelineValueQueryBuilder ExceptVisualizationType() =>
            ExceptField("visualization_type");
    }
}
