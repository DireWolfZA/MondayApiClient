using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ItemQueryBuilder : GraphQlQueryBuilder<ItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
                new GraphQlFieldMetadata { Name = "assets", IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
                new GraphQlFieldMetadata { Name = "board", IsComplex = true, QueryBuilderType = typeof(BoardQueryBuilder) },
                new GraphQlFieldMetadata { Name = "column_values", IsComplex = true, QueryBuilderType = typeof(ColumnValueQueryBuilder) },
                new GraphQlFieldMetadata { Name = "created_at" },
                new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
                new GraphQlFieldMetadata { Name = "creator_id" },
                new GraphQlFieldMetadata { Name = "email" },
                new GraphQlFieldMetadata { Name = "group", IsComplex = true, QueryBuilderType = typeof(GroupQueryBuilder) },
                new GraphQlFieldMetadata { Name = "id" },
                new GraphQlFieldMetadata { Name = "name" },
                new GraphQlFieldMetadata { Name = "parent_item", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
                new GraphQlFieldMetadata { Name = "relative_link" },
                new GraphQlFieldMetadata { Name = "state" },
                new GraphQlFieldMetadata { Name = "subitems", IsComplex = true, QueryBuilderType = typeof(ItemQueryBuilder) },
                new GraphQlFieldMetadata { Name = "subscribers", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
                new GraphQlFieldMetadata { Name = "updated_at" },
                new GraphQlFieldMetadata { Name = "updates", IsComplex = true, QueryBuilderType = typeof(UpdateQueryBuilder) }
            };

        protected override string TypeName { get { return "Item"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public ItemQueryBuilder WithAssets(AssetQueryBuilder assetQueryBuilder, QueryBuilderParameter<AssetsSource?> assetsSource = null, QueryBuilderParameter<IEnumerable<string>> columnIds = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (assetsSource != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "assets_source", ArgumentValue = assetsSource });

            if (columnIds != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "column_ids", ArgumentValue = columnIds });

            return WithObjectField("assets", alias, assetQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ItemQueryBuilder ExceptAssets() {
            return ExceptField("assets");
        }

        public ItemQueryBuilder WithBoard(BoardQueryBuilder boardQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("board", alias, boardQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptBoard() {
            return ExceptField("board");
        }

        public ItemQueryBuilder WithColumnValues(ColumnValueQueryBuilder columnValueQueryBuilder, QueryBuilderParameter<IEnumerable<string>> ids = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (ids != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "ids", ArgumentValue = ids });

            return WithObjectField("column_values", alias, columnValueQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ItemQueryBuilder ExceptColumnValues() {
            return ExceptField("column_values");
        }

        public ItemQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public ItemQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptCreator() {
            return ExceptField("creator");
        }

        public ItemQueryBuilder WithCreatorId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptCreatorId() {
            return ExceptField("creator_id");
        }

        public ItemQueryBuilder WithEmail(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("email", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptEmail() {
            return ExceptField("email");
        }

        public ItemQueryBuilder WithGroup(GroupQueryBuilder groupQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("group", alias, groupQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptGroup() {
            return ExceptField("group");
        }

        public ItemQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public ItemQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public ItemQueryBuilder WithParentItem(ItemQueryBuilder itemQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("parent_item", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptParentItem() {
            return ExceptField("parent_item");
        }

        public ItemQueryBuilder WithRelativeLink(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("relative_link", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptRelativeLink() {
            return ExceptField("relative_link");
        }

        public ItemQueryBuilder WithState(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("state", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptState() {
            return ExceptField("state");
        }

        public ItemQueryBuilder WithSubitems(ItemQueryBuilder itemQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("subitems", alias, itemQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptSubitems() {
            return ExceptField("subitems");
        }

        public ItemQueryBuilder WithSubscribers(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("subscribers", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptSubscribers() {
            return ExceptField("subscribers");
        }

        public ItemQueryBuilder WithUpdatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("updated_at", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemQueryBuilder ExceptUpdatedAt() {
            return ExceptField("updated_at");
        }

        public ItemQueryBuilder WithUpdates(UpdateQueryBuilder updateQueryBuilder, QueryBuilderParameter<int?> limit = null, QueryBuilderParameter<int?> page = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });

            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });

            return WithObjectField("updates", alias, updateQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public ItemQueryBuilder ExceptUpdates() {
            return ExceptField("updates");
        }
    }
}
