using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FileAssetValueQueryBuilder : GraphQlQueryBuilder<FileAssetValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "asset", IsComplex = true, QueryBuilderType = typeof(AssetQueryBuilder) },
            new GraphQlFieldMetadata { Name = "asset_id" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "is_image" },
            new GraphQlFieldMetadata { Name = "name" }
        };

        protected override string TypeName => "FileAssetValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FileAssetValueQueryBuilder WithAsset(AssetQueryBuilder assetQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("asset", alias, assetQueryBuilder, new GraphQlDirective[] { include, skip });
        public FileAssetValueQueryBuilder ExceptAsset() =>
            ExceptField("asset");
        public FileAssetValueQueryBuilder WithAssetId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("asset_id", alias, new GraphQlDirective[] { include, skip });
        public FileAssetValueQueryBuilder ExceptAssetId() =>
            ExceptField("asset_id");
        public FileAssetValueQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public FileAssetValueQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public FileAssetValueQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public FileAssetValueQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public FileAssetValueQueryBuilder WithCreatorId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        public FileAssetValueQueryBuilder ExceptCreatorId() =>
            ExceptField("creator_id");
        public FileAssetValueQueryBuilder WithIsImage(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("is_image", alias, new GraphQlDirective[] { include, skip });
        public FileAssetValueQueryBuilder ExceptIsImage() =>
            ExceptField("is_image");
        public FileAssetValueQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        public FileAssetValueQueryBuilder ExceptName() =>
            ExceptField("name");
    }
}
