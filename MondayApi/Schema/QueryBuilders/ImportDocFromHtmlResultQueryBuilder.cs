using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ImportDocFromHtmlResultQueryBuilder : GraphQlQueryBuilder<ImportDocFromHtmlResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "doc_id" },
            new GraphQlFieldMetadata { Name = "error" }
        };

        protected override string TypeName => "ImportDocFromHtmlResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ImportDocFromHtmlResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public ImportDocFromHtmlResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public ImportDocFromHtmlResultQueryBuilder WithDocID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("doc_id", alias, new GraphQlDirective?[] { include, skip });
        public ImportDocFromHtmlResultQueryBuilder ExceptDocID() =>
            ExceptField("doc_id");
        public ImportDocFromHtmlResultQueryBuilder WithError(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("error", alias, new GraphQlDirective?[] { include, skip });
        public ImportDocFromHtmlResultQueryBuilder ExceptError() =>
            ExceptField("error");
    }
}
