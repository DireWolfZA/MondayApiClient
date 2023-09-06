using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FileDocValueQueryBuilder : GraphQlQueryBuilder<FileDocValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "creator", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) },
            new GraphQlFieldMetadata { Name = "creator_id" },
            new GraphQlFieldMetadata { Name = "doc", IsComplex = true, QueryBuilderType = typeof(DocumentQueryBuilder) },
            new GraphQlFieldMetadata { Name = "file_id" },
            new GraphQlFieldMetadata { Name = "object_id" },
            new GraphQlFieldMetadata { Name = "url" }
        };

        protected override string TypeName => "FileDocValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FileDocValueQueryBuilder WithCreatedAt(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective[] { include, skip });
        public FileDocValueQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public FileDocValueQueryBuilder WithCreator(UserQueryBuilder userQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("creator", alias, userQueryBuilder, new GraphQlDirective[] { include, skip });
        public FileDocValueQueryBuilder ExceptCreator() =>
            ExceptField("creator");
        public FileDocValueQueryBuilder WithCreatorID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("creator_id", alias, new GraphQlDirective[] { include, skip });
        public FileDocValueQueryBuilder ExceptCreatorID() =>
            ExceptField("creator_id");
        public FileDocValueQueryBuilder WithDoc(DocumentQueryBuilder documentQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithObjectField("doc", alias, documentQueryBuilder, new GraphQlDirective[] { include, skip });
        public FileDocValueQueryBuilder ExceptDoc() =>
            ExceptField("doc");
        public FileDocValueQueryBuilder WithFileID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("file_id", alias, new GraphQlDirective[] { include, skip });
        public FileDocValueQueryBuilder ExceptFileID() =>
            ExceptField("file_id");
        public FileDocValueQueryBuilder WithObjectID(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("object_id", alias, new GraphQlDirective[] { include, skip });
        public FileDocValueQueryBuilder ExceptObjectID() =>
            ExceptField("object_id");
        public FileDocValueQueryBuilder WithUrl(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("url", alias, new GraphQlDirective[] { include, skip });
        public FileDocValueQueryBuilder ExceptUrl() =>
            ExceptField("url");
    }
}
