using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DirectDocValueQueryBuilder : GraphQlQueryBuilder<DirectDocValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "file", IsComplex = true, QueryBuilderType = typeof(DirectDocValueQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "DirectDocValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DirectDocValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DirectDocValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public DirectDocValueQueryBuilder WithFile(DirectDocValueQueryBuilder directDocValueQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("file", alias, directDocValueQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DirectDocValueQueryBuilder ExceptFile() =>
            ExceptField("file");
        public DirectDocValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DirectDocValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public DirectDocValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public DirectDocValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public DirectDocValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public DirectDocValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public DirectDocValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public DirectDocValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
