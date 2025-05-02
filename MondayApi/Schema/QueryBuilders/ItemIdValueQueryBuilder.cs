using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ItemIDValueQueryBuilder : GraphQlQueryBuilder<ItemIDValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "item_id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "value" }
        };

        protected override string TypeName => "ItemIdValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ItemIDValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ItemIDValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public ItemIDValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ItemIDValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public ItemIDValueQueryBuilder WithItemID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("item_id", alias, new GraphQlDirective?[] { include, skip });
        public ItemIDValueQueryBuilder ExceptItemID() =>
            ExceptField("item_id");
        public ItemIDValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public ItemIDValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public ItemIDValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public ItemIDValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public ItemIDValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public ItemIDValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
