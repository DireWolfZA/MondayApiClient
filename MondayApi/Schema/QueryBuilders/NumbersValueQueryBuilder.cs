using System.Collections.Generic;

namespace MondayApi.Schema {
    public class NumbersValueQueryBuilder : GraphQlQueryBuilder<NumbersValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "direction" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "number" },
            new GraphQlFieldMetadata { Name = "symbol" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "NumbersValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public NumbersValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public NumbersValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public NumbersValueQueryBuilder WithDirection(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("direction", alias, new GraphQlDirective?[] { include, skip });
        public NumbersValueQueryBuilder ExceptDirection() =>
            ExceptField("direction");
        public NumbersValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public NumbersValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public NumbersValueQueryBuilder WithNumber(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("number", alias, new GraphQlDirective?[] { include, skip });
        public NumbersValueQueryBuilder ExceptNumber() =>
            ExceptField("number");
        public NumbersValueQueryBuilder WithSymbol(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("symbol", alias, new GraphQlDirective?[] { include, skip });
        public NumbersValueQueryBuilder ExceptSymbol() =>
            ExceptField("symbol");
        public NumbersValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public NumbersValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public NumbersValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public NumbersValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public NumbersValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public NumbersValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
