using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ItemIdValueQueryBuilder : GraphQlQueryBuilder<ItemIdValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "item_id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "ItemIdValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ItemIdValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public ItemIdValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public ItemIdValueQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public ItemIdValueQueryBuilder ExceptId() =>
            ExceptField("id");
        public ItemIdValueQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("item_id", alias, new GraphQlDirective[] { include, skip });
        public ItemIdValueQueryBuilder ExceptItemId() =>
            ExceptField("item_id");
        public ItemIdValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public ItemIdValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public ItemIdValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public ItemIdValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public ItemIdValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public ItemIdValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
