using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ButtonValueQueryBuilder : GraphQlQueryBuilder<ButtonValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "label" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "ButtonValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ButtonValueQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        public ButtonValueQueryBuilder ExceptColor() =>
            ExceptField("color");
        public ButtonValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public ButtonValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public ButtonValueQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public ButtonValueQueryBuilder ExceptId() =>
            ExceptField("id");
        public ButtonValueQueryBuilder WithLabel(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("label", alias, new GraphQlDirective[] { include, skip });
        public ButtonValueQueryBuilder ExceptLabel() =>
            ExceptField("label");
        public ButtonValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public ButtonValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public ButtonValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public ButtonValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public ButtonValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public ButtonValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
