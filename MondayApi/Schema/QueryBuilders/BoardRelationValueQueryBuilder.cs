using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BoardRelationValueQueryBuilder : GraphQlQueryBuilder<BoardRelationValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "linked_item_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "linked_items", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "BoardRelationValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BoardRelationValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public BoardRelationValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public BoardRelationValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public BoardRelationValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public BoardRelationValueQueryBuilder WithLinkedItemIDs(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("linked_item_ids", alias, new GraphQlDirective[] { include, skip });
        public BoardRelationValueQueryBuilder ExceptLinkedItemIDs() =>
            ExceptField("linked_item_ids");
        public BoardRelationValueQueryBuilder WithLinkedItems(ItemQueryBuilder itemQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("linked_items", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip });
        public BoardRelationValueQueryBuilder ExceptLinkedItems() =>
            ExceptField("linked_items");
        public BoardRelationValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public BoardRelationValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public BoardRelationValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public BoardRelationValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public BoardRelationValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public BoardRelationValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public BoardRelationValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public BoardRelationValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
