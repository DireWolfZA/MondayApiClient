using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ItemQueryBuilder : GraphQlQueryBuilder<ItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "updates", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) },
            new GraphQlFieldMetadata { Name = "assets", IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "board", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
            new GraphQlFieldMetadata { Name = "column_values", IsComplex = true, QueryBuilderType = typeof(ColumnValueQueryBuilder) },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "description", IsComplex = true, QueryBuilderType = typeof(ItemDescriptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "email" },
            new GraphQlFieldMetadata { Name = "group", IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
            new GraphQlFieldMetadata { Name = "linked_items", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "parent_item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "relative_link" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "subitems", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "subscribers", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "url" }
        };

        protected override string TypeName => "Item";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ItemQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptID() =>
            ExceptField("id");
        public ItemQueryBuilder WithUpdates(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            return WithObjectField("updates", alias, updateQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public ItemQueryBuilder ExceptUpdates() =>
            ExceptField("updates");
        public ItemQueryBuilder WithAssets(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<AssetsSource?>? assetsSource = null, QueryBuilderParameter<IEnumerable<string?>>? columnIDs = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (assetsSource != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "assets_source", ArgumentValue = assetsSource });
            if (columnIDs != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_ids", ArgumentValue = columnIDs });
            return WithObjectField("assets", alias, assetQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public ItemQueryBuilder ExceptAssets() =>
            ExceptField("assets");
        public ItemQueryBuilder WithBoard(BoardQueryBuilder boardQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("board", alias, boardQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptBoard() =>
            ExceptField("board");
        public ItemQueryBuilder WithColumnValues(ColumnValueQueryBuilder columnValueQueryBuilder, QueryBuilderParameter<IEnumerable<ColumnCapability>>? capabilities = null, QueryBuilderParameter<IEnumerable<string>>? ids = null, QueryBuilderParameter<IEnumerable<ColumnType>>? types = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (capabilities != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "capabilities", ArgumentValue = capabilities });
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });
            if (types != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "types", ArgumentValue = types });
            return WithObjectField("column_values", alias, columnValueQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public ItemQueryBuilder ExceptColumnValues() =>
            ExceptField("column_values");
        public ItemQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public ItemQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public ItemQueryBuilder WithCreatorID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptCreatorID() =>
            ExceptField("creator_id");
        public ItemQueryBuilder WithDescription(ItemDescriptionQueryBuilder itemDescriptionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("description", alias, itemDescriptionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public ItemQueryBuilder WithEmail(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("email", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptEmail() =>
            ExceptField("email");
        public ItemQueryBuilder WithGroup(GroupQueryBuilder groupQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("group", alias, groupQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptGroup() =>
            ExceptField("group");
        public ItemQueryBuilder WithLinkedItems(ItemQueryBuilder itemQueryBuilder, QueryBuilderParameter<string> linkToItemColumnID, QueryBuilderParameter<string> linkedBoardID, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "link_to_item_column_id", ArgumentValue = linkToItemColumnID });
            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "linked_board_id", ArgumentValue = linkedBoardID });
            return WithObjectField("linked_items", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public ItemQueryBuilder ExceptLinkedItems() =>
            ExceptField("linked_items");
        public ItemQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptName() =>
            ExceptField("name");
        public ItemQueryBuilder WithParentItem(ItemQueryBuilder itemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("parent_item", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptParentItem() =>
            ExceptField("parent_item");
        public ItemQueryBuilder WithRelativeLink(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("relative_link", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptRelativeLink() =>
            ExceptField("relative_link");
        public ItemQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptState() =>
            ExceptField("state");
        public ItemQueryBuilder WithSubitems(ItemQueryBuilder itemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("subitems", alias, itemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptSubitems() =>
            ExceptField("subitems");
        public ItemQueryBuilder WithSubscribers(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("subscribers", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptSubscribers() =>
            ExceptField("subscribers");
        public ItemQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public ItemQueryBuilder WithURL(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective?[] { include, skip });
        public ItemQueryBuilder ExceptURL() =>
            ExceptField("url");
    }
}
