using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FileAssetInvalidValueQueryBuilder : GraphQlQueryBuilder<FileAssetInvalidValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "asset_id" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "error" },
            new GraphQlFieldMetadata { Name = "name" }
        };

        protected override string TypeName => "FileAssetInvalidValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FileAssetInvalidValueQueryBuilder WithAssetID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("asset_id", alias, new GraphQlDirective?[] { include, skip });
        public FileAssetInvalidValueQueryBuilder ExceptAssetID() =>
            ExceptField("asset_id");
        public FileAssetInvalidValueQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public FileAssetInvalidValueQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public FileAssetInvalidValueQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FileAssetInvalidValueQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public FileAssetInvalidValueQueryBuilder WithCreatorID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective?[] { include, skip });
        public FileAssetInvalidValueQueryBuilder ExceptCreatorID() =>
            ExceptField("creator_id");
        public FileAssetInvalidValueQueryBuilder WithError(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("error", alias, new GraphQlDirective?[] { include, skip });
        public FileAssetInvalidValueQueryBuilder ExceptError() =>
            ExceptField("error");
        public FileAssetInvalidValueQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public FileAssetInvalidValueQueryBuilder ExceptName() =>
            ExceptField("name");
    }
}
