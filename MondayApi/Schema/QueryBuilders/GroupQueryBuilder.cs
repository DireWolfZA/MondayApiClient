using System.Collections.Generic;

namespace MondayApi.Schema {
    public class GroupQueryBuilder : GraphQlQueryBuilder<GroupQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "archived" },
            new GraphQlFieldMetadata { Name = "color" },
            new GraphQlFieldMetadata { Name = "deleted" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "items_page", RequiresParameters = true, IsComplex = true, QueryBuilderType = typeof(ItemsResponseQueryBuilder) },
            new GraphQlFieldMetadata { Name = "position" },
            new GraphQlFieldMetadata { Name = "title" }
        };

        protected override string TypeName => "Group";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public GroupQueryBuilder WithItemsPage(ItemsResponseQueryBuilder itemsResponseQueryBuilder, QueryBuilderParameter<int> limit, QueryBuilderParameter<ItemsQuery> queryParams = null, QueryBuilderParameter<string> cursor = null, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (queryParams != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "query_params", ArgumentValue = queryParams });

            if (cursor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor });

            args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            return WithObjectField("items_page", alias, itemsResponseQueryBuilder, new GraphQlDirective[] { include, skip }, args);
        }

        public GroupQueryBuilder WithArchived(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("archived", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptArchived() =>
            ExceptField("archived");
        public GroupQueryBuilder WithColor(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("color", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptColor() =>
            ExceptField("color");
        public GroupQueryBuilder WithDeleted(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("deleted", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptDeleted() =>
            ExceptField("deleted");
        public GroupQueryBuilder WithID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptID() =>
            ExceptField("id");
        public GroupQueryBuilder ExceptItemsPage() =>
            ExceptField("items_page");
        public GroupQueryBuilder WithPosition(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("position", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptPosition() =>
            ExceptField("position");
        public GroupQueryBuilder WithTitle(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective[] { include, skip });
        public GroupQueryBuilder ExceptTitle() =>
            ExceptField("title");
    }
}
