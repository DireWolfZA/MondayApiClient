using System.Collections.Generic;

namespace MondayApi.Schema {
    public class WorldClockValueQueryBuilder : GraphQlQueryBuilder<WorldClockValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "is_leaf" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "timezone" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "WorldClockValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public WorldClockValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public WorldClockValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public WorldClockValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public WorldClockValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public WorldClockValueQueryBuilder WithIsLeaf(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("is_leaf", alias, new GraphQlDirective?[] { include, skip });
        public WorldClockValueQueryBuilder ExceptIsLeaf() =>
            ExceptField("is_leaf");
        public WorldClockValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public WorldClockValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public WorldClockValueQueryBuilder WithTimezone(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("timezone", alias, new GraphQlDirective?[] { include, skip });
        public WorldClockValueQueryBuilder ExceptTimezone() =>
            ExceptField("timezone");
        public WorldClockValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public WorldClockValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public WorldClockValueQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public WorldClockValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public WorldClockValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public WorldClockValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
