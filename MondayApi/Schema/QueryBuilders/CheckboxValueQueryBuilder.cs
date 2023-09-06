using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CheckboxValueQueryBuilder : GraphQlQueryBuilder<CheckboxValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "checked" },
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "CheckboxValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CheckboxValueQueryBuilder WithChecked(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("checked", alias, new GraphQlDirective[] { include, skip });
        public CheckboxValueQueryBuilder ExceptChecked() =>
            ExceptField("checked");
        public CheckboxValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public CheckboxValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public CheckboxValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public CheckboxValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public CheckboxValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public CheckboxValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public CheckboxValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public CheckboxValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public CheckboxValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public CheckboxValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public CheckboxValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public CheckboxValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
