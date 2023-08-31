using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AssetQueryBuilder : GraphQlQueryBuilder<AssetQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new[]
            {
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

        protected override string TypeName { get { return "Asset"; } }

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } }

        public AssetQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptCreatedAt() {
            return ExceptField("created_at");
        }

        public AssetQueryBuilder WithFileExtension(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("file_extension", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptFileExtension() {
            return ExceptField("file_extension");
        }

        public AssetQueryBuilder WithFileSize(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("file_size", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptFileSize() {
            return ExceptField("file_size");
        }

        public AssetQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptId() {
            return ExceptField("id");
        }

        public AssetQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptName() {
            return ExceptField("name");
        }

        public AssetQueryBuilder WithOriginalGeometry(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("original_geometry", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptOriginalGeometry() {
            return ExceptField("original_geometry");
        }

        public AssetQueryBuilder WithPublicUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("public_url", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptPublicUrl() {
            return ExceptField("public_url");
        }

        public AssetQueryBuilder WithUploadedBy(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithObjectField("uploaded_by", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptUploadedBy() {
            return ExceptField("uploaded_by");
        }

        public AssetQueryBuilder WithUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("url", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptUrl() {
            return ExceptField("url");
        }

        public AssetQueryBuilder WithUrlThumbnail(string alias = null, IncludeDirective include = null, SkipDirective skip = null) {
            return WithScalarField("url_thumbnail", alias, new GraphQlDirective[] { include, skip });
        }

        public AssetQueryBuilder ExceptUrlThumbnail() {
            return ExceptField("url_thumbnail");
        }
    }
}
