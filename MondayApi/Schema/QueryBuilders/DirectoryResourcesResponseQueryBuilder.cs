using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DirectoryResourcesResponseQueryBuilder : GraphQlQueryBuilder<DirectoryResourcesResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "resources", IsComplex = true, QueryBuilderType = typeof(DirectoryResourceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "cursor" }
        };

        protected override string TypeName => "DirectoryResourcesResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DirectoryResourcesResponseQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DirectoryResourcesResponseQueryBuilder ExceptID() =>
            ExceptField("id");
        public DirectoryResourcesResponseQueryBuilder WithResources(DirectoryResourceQueryBuilder directoryResourceQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("resources", alias, directoryResourceQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DirectoryResourcesResponseQueryBuilder ExceptResources() =>
            ExceptField("resources");
        public DirectoryResourcesResponseQueryBuilder WithCursor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("cursor", alias, new GraphQlDirective?[] { include, skip });
        public DirectoryResourcesResponseQueryBuilder ExceptCursor() =>
            ExceptField("cursor");
    }
}
