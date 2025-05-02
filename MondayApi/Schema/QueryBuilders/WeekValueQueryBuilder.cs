using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WeekValueQueryBuilder : GraphQlQueryBuilder<WeekValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "end_date" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "start_date" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "WeekValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WeekValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public WeekValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public WeekValueQueryBuilder WithEndDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("end_date", alias, new GraphQlDirective?[] { include, skip });
        public WeekValueQueryBuilder ExceptEndDate() =>
            ExceptField("end_date");
        public WeekValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public WeekValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public WeekValueQueryBuilder WithStartDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("start_date", alias, new GraphQlDirective?[] { include, skip });
        public WeekValueQueryBuilder ExceptStartDate() =>
            ExceptField("start_date");
        public WeekValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public WeekValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public WeekValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public WeekValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public WeekValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public WeekValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
