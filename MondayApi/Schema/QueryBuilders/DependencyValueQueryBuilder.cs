using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DependencyValueQueryBuilder : GraphQlQueryBuilder<DependencyValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "linked_item_ids" },
            new GraphQlFieldMetadata { Name = "linked_items", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value", IsComplex = true }
        };

        protected override string TypeName => "DependencyValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DependencyValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective[] { include, skip });
        public DependencyValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public DependencyValueQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public DependencyValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public DependencyValueQueryBuilder WithLinkedItemIDs(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("linked_item_ids", alias, new GraphQlDirective[] { include, skip });
        public DependencyValueQueryBuilder ExceptLinkedItemIDs() =>
            ExceptField("linked_item_ids");
        public DependencyValueQueryBuilder WithLinkedItems(ItemQueryBuilder itemQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("linked_items", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip });
        public DependencyValueQueryBuilder ExceptLinkedItems() =>
            ExceptField("linked_items");
        public DependencyValueQueryBuilder WithText(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective[] { include, skip });
        public DependencyValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public DependencyValueQueryBuilder WithType(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective[] { include, skip });
        public DependencyValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public DependencyValueQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        public DependencyValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public DependencyValueQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        public DependencyValueQueryBuilder ExceptValue() =>
            ExceptField("value");
    }
}
