using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ItemsResponseQueryBuilder : GraphQlQueryBuilder<ItemsResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "cursor" },
            new GraphQlFieldMetadata { Name = "items", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) }
        };

        protected override string TypeName => "ItemsResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ItemsResponseQueryBuilder WithCursor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("cursor", alias, new GraphQlDirective[] { include, skip });
        public ItemsResponseQueryBuilder ExceptCursor() =>
            ExceptField("cursor");
        public ItemsResponseQueryBuilder WithItems(ItemQueryBuilder itemQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("items", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip });
        public ItemsResponseQueryBuilder ExceptItems() =>
            ExceptField("items");
    }
}
