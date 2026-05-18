using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DiffBlockQueryBuilder : GraphQlQueryBuilder<DiffBlockQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "content" },
            new GraphQlFieldMetadata { Name = "summary" },
            new GraphQlFieldMetadata { Name = "parent_block_id" },
            new GraphQlFieldMetadata { Name = "changes", IsComplex = true, QueryBuilderType = typeof(BlockChangesQueryBuilder) }
        };

        protected override string TypeName => "DiffBlock";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DiffBlockQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public DiffBlockQueryBuilder ExceptID() =>
            ExceptField("id");
        public DiffBlockQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public DiffBlockQueryBuilder ExceptType() =>
            ExceptField("type");
        public DiffBlockQueryBuilder WithContent(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("content", alias, new GraphQlDirective?[] { include, skip });
        public DiffBlockQueryBuilder ExceptContent() =>
            ExceptField("content");
        public DiffBlockQueryBuilder WithSummary(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("summary", alias, new GraphQlDirective?[] { include, skip });
        public DiffBlockQueryBuilder ExceptSummary() =>
            ExceptField("summary");
        public DiffBlockQueryBuilder WithParentBlockID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("parent_block_id", alias, new GraphQlDirective?[] { include, skip });
        public DiffBlockQueryBuilder ExceptParentBlockID() =>
            ExceptField("parent_block_id");
        public DiffBlockQueryBuilder WithChanges(BlockChangesQueryBuilder blockChangesQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("changes", alias, blockChangesQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DiffBlockQueryBuilder ExceptChanges() =>
            ExceptField("changes");
    }
}
