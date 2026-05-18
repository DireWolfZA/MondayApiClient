using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DocVersionHistoryQueryBuilder : GraphQlQueryBuilder<DocVersionHistoryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "doc_id" },
            new GraphQlFieldMetadata { Name = "restoring_points", IsComplex = true, QueryBuilderType = typeof(DocRestoringPointQueryBuilder) }
        };

        protected override string TypeName => "DocVersionHistory";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DocVersionHistoryQueryBuilder WithDocID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("doc_id", alias, new GraphQlDirective?[] { include, skip });
        public DocVersionHistoryQueryBuilder ExceptDocID() =>
            ExceptField("doc_id");
        public DocVersionHistoryQueryBuilder WithRestoringPoints(DocRestoringPointQueryBuilder docRestoringPointQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("restoring_points", alias, docRestoringPointQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DocVersionHistoryQueryBuilder ExceptRestoringPoints() =>
            ExceptField("restoring_points");
    }
}
