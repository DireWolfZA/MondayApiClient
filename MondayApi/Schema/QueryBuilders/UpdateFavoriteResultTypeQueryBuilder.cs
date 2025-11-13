using System.Collections.Generic;

namespace MondayApi.Schema {
    public class UpdateFavoriteResultTypeQueryBuilder : GraphQlQueryBuilder<UpdateFavoriteResultTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "favorite", IsComplex = true, QueryBuilderType = typeof(GraphQLHierarchyObjectItemQueryBuilder) }
        };

        protected override string TypeName => "UpdateFavoriteResultType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public UpdateFavoriteResultTypeQueryBuilder WithFavorite(GraphQLHierarchyObjectItemQueryBuilder graphqlHierarchyObjectItemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("favorite", alias, graphqlHierarchyObjectItemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public UpdateFavoriteResultTypeQueryBuilder ExceptFavorite() =>
            ExceptField("favorite");
    }
}
