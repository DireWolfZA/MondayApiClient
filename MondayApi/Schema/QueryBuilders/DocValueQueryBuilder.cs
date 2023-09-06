using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocValueQueryBuilder : GraphQlQueryBuilder<DocValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "file", IsComplex = true, QueryBuilderType = typeof(FileDocValueQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "DocValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public DocValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public DocValueQueryBuilder WithFile(FileDocValueQueryBuilder fileDocValueQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("file", alias, fileDocValueQueryBuilder, new GraphQlDirective[] { include, skip });
        public DocValueQueryBuilder ExceptFile() =>
            ExceptField("file");
        public DocValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public DocValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public DocValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public DocValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public DocValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public DocValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public DocValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public DocValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
