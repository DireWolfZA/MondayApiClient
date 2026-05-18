using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocVersionDiffQueryBuilder : GraphQlQueryBuilder<DocVersionDiffQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "doc_id" },
            new GraphQlFieldMetadata { Name = "date" },
            new GraphQlFieldMetadata { Name = "prev_date" },
            new GraphQlFieldMetadata { Name = "blocks", IsComplex = true, QueryBuilderType = typeof(DiffBlockQueryBuilder) }
        };

        protected override string TypeName => "DocVersionDiff";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocVersionDiffQueryBuilder WithDocID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("doc_id", alias, new GraphQlDirective?[] { include, skip });
        public DocVersionDiffQueryBuilder ExceptDocID() =>
            ExceptField("doc_id");
        public DocVersionDiffQueryBuilder WithDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("date", alias, new GraphQlDirective?[] { include, skip });
        public DocVersionDiffQueryBuilder ExceptDate() =>
            ExceptField("date");
        public DocVersionDiffQueryBuilder WithPrevDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("prev_date", alias, new GraphQlDirective?[] { include, skip });
        public DocVersionDiffQueryBuilder ExceptPrevDate() =>
            ExceptField("prev_date");
        public DocVersionDiffQueryBuilder WithBlocks(DiffBlockQueryBuilder diffBlockQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("blocks", alias, diffBlockQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DocVersionDiffQueryBuilder ExceptBlocks() =>
            ExceptField("blocks");
    }
}
