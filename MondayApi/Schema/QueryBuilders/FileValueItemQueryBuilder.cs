using System;
using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FileValueItemQueryBuilder : GraphQlQueryBuilder<FileValueItemQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = Array.Empty<GraphQlFieldMetadata>();

        public FileValueItemQueryBuilder() => WithTypeName();
        protected override string TypeName => "FileValueItem";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FileValueItemQueryBuilder WithFileAssetValueFragment(FileAssetValueQueryBuilder fileAssetValueQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(fileAssetValueQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FileValueItemQueryBuilder WithFileDocValueFragment(FileDocValueQueryBuilder fileDocValueQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(fileDocValueQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FileValueItemQueryBuilder WithFileLinkValueFragment(FileLinkValueQueryBuilder fileLinkValueQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(fileLinkValueQueryBuilder, new GraphQlDirective?[] { include, skip });
    }
}
