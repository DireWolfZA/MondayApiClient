using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DropdownValueQueryBuilder : GraphQlQueryBuilder<DropdownValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true },
            new GraphQlFieldMetadata { Name = "values", IsComplex = true, QueryBuilderType = typeof(DropdownValueOptionQueryBuilder) }
        };

        protected override string TypeName => "DropdownValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DropdownValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public DropdownValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public DropdownValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public DropdownValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public DropdownValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public DropdownValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public DropdownValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public DropdownValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public DropdownValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public DropdownValueQueryBuilder ExceptValue() =>
            ExceptField("value");
        public DropdownValueQueryBuilder WithValues(DropdownValueOptionQueryBuilder dropdownValueOptionQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("values", alias, dropdownValueOptionQueryBuilder, new GraphQlDirective[] { include, skip });
        public DropdownValueQueryBuilder ExceptValues() =>
            ExceptField("values");
    }
}
