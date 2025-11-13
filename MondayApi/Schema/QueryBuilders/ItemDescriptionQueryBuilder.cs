using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ItemDescriptionQueryBuilder : GraphQlQueryBuilder<ItemDescriptionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "blocks", IsComplex = true, QueryBuilderType = typeof(DocumentBlockQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" }
        };

        protected override string TypeName => "ItemDescription";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ItemDescriptionQueryBuilder WithBlocks(DocumentBlockQueryBuilder documentBlockQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<int?>? page = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (page != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "page", ArgumentValue = page });
            return WithObjectField("blocks", alias, documentBlockQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public ItemDescriptionQueryBuilder ExceptBlocks() =>
            ExceptField("blocks");
        public ItemDescriptionQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ItemDescriptionQueryBuilder ExceptID() =>
            ExceptField("id");
    }
}
