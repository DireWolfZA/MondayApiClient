using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AssetQueryBuilder : GraphQlQueryBuilder<AssetQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "file_extension" },
            new GraphQlFieldMetadata { Name = "file_size" },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "original_geometry" },
            new GraphQlFieldMetadata { Name = "public_url" },
            new GraphQlFieldMetadata { Name = "uploaded_by", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "url" },
            new GraphQlFieldMetadata { Name = "url_thumbnail" }
        };

        protected override string TypeName => "Asset";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AssetQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public AssetQueryBuilder WithFileExtension(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("file_extension", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptFileExtension() =>
            ExceptField("file_extension");
        public AssetQueryBuilder WithFileSize(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("file_size", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptFileSize() =>
            ExceptField("file_size");
        public AssetQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptId() =>
            ExceptField("id");
        public AssetQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptName() =>
            ExceptField("name");
        public AssetQueryBuilder WithOriginalGeometry(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("original_geometry", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptOriginalGeometry() =>
            ExceptField("original_geometry");
        public AssetQueryBuilder WithPublicUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("public_url", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptPublicUrl() =>
            ExceptField("public_url");
        public AssetQueryBuilder WithUploadedBy(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("uploaded_by", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptUploadedBy() =>
            ExceptField("uploaded_by");
        public AssetQueryBuilder WithUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptUrl() =>
            ExceptField("url");
        public AssetQueryBuilder WithUrlThumbnail(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("url_thumbnail", alias, new GraphQlDirective[] { include, skip });
        public AssetQueryBuilder ExceptUrlThumbnail() =>
            ExceptField("url_thumbnail");
    }
}