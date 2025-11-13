using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CreateFavoriteResultTypeQueryBuilder : GraphQlQueryBuilder<CreateFavoriteResultTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "favorite", IsComplex = true, QueryBuilderType = typeof(GraphQLHierarchyObjectItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "folder", IsComplex = true, QueryBuilderType = typeof(GraphQLFolderQueryBuilder) }
        };

        protected override string TypeName => "CreateFavoriteResultType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CreateFavoriteResultTypeQueryBuilder WithFavorite(GraphQLHierarchyObjectItemQueryBuilder graphqlHierarchyObjectItemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("favorite", alias, graphqlHierarchyObjectItemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CreateFavoriteResultTypeQueryBuilder ExceptFavorite() =>
            ExceptField("favorite");
        public CreateFavoriteResultTypeQueryBuilder WithFolder(GraphQLFolderQueryBuilder graphqlFolderQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("folder", alias, graphqlFolderQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CreateFavoriteResultTypeQueryBuilder ExceptFolder() =>
            ExceptField("folder");
    }
}
