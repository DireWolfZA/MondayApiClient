using System.Collections.Generic;

namespace MondayApi.Schema {
    public class HourValueQueryBuilder : GraphQlQueryBuilder<HourValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "hour" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "minute" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "HourValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public HourValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public HourValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public HourValueQueryBuilder WithHour(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("hour", alias, new GraphQlDirective[] { include, skip });
        public HourValueQueryBuilder ExceptHour() =>
            ExceptField("hour");
        public HourValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public HourValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public HourValueQueryBuilder WithMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("minute", alias, new GraphQlDirective[] { include, skip });
        public HourValueQueryBuilder ExceptMinute() =>
            ExceptField("minute");
        public HourValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public HourValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public HourValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public HourValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public HourValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public HourValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public HourValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public HourValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
