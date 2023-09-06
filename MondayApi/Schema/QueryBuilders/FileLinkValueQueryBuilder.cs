using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FileLinkValueQueryBuilder : GraphQlQueryBuilder<FileLinkValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "file_id" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "url" }
        };

        protected override string TypeName => "FileLinkValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FileLinkValueQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public FileLinkValueQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public FileLinkValueQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public FileLinkValueQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public FileLinkValueQueryBuilder WithCreatorID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        public FileLinkValueQueryBuilder ExceptCreatorID() =>
            ExceptField("creator_id");
        public FileLinkValueQueryBuilder WithFileID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("file_id", alias, new GraphQlDirective[] { include, skip });
        public FileLinkValueQueryBuilder ExceptFileID() =>
            ExceptField("file_id");
        public FileLinkValueQueryBuilder WithKind(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective[] { include, skip });
        public FileLinkValueQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public FileLinkValueQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        public FileLinkValueQueryBuilder ExceptName() =>
            ExceptField("name");
        public FileLinkValueQueryBuilder WithUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective[] { include, skip });
        public FileLinkValueQueryBuilder ExceptUrl() =>
            ExceptField("url");
    }
}
