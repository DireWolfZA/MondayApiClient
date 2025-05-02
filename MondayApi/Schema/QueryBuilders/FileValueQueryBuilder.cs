using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FileValueQueryBuilder : GraphQlQueryBuilder<FileValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "files", IsComplex = true, QueryBuilderType = typeof(FileValueItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "FileValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FileValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FileValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public FileValueQueryBuilder WithFiles(FileValueItemQueryBuilder fileValueItemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("files", alias, fileValueItemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FileValueQueryBuilder ExceptFiles() =>
            ExceptField("files");
        public FileValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public FileValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public FileValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public FileValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public FileValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public FileValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public FileValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public FileValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
