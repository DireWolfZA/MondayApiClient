using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ColumnValueQueryBuilder : GraphQlQueryBuilder<ColumnValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "additional_info", IsComplex = true },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "ColumnValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ColumnValueQueryBuilder WithAdditionalInfo(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("additional_info", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptAdditionalInfo() =>
            ExceptField("additional_info");
        public ColumnValueQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public ColumnValueQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptId() =>
            ExceptField("id");
        public ColumnValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public ColumnValueQueryBuilder WithTitle(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public ColumnValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public ColumnValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public ColumnValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
