using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ImportDocFromHTMLResultQueryBuilder : GraphQlQueryBuilder<ImportDocFromHTMLResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "doc_id" },
            new GraphQlFieldMetadata { Name = "error" }
        };

        protected override string TypeName => "ImportDocFromHtmlResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ImportDocFromHTMLResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public ImportDocFromHTMLResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public ImportDocFromHTMLResultQueryBuilder WithDocID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("doc_id", alias, new GraphQlDirective?[] { include, skip });
        public ImportDocFromHTMLResultQueryBuilder ExceptDocID() =>
            ExceptField("doc_id");
        public ImportDocFromHTMLResultQueryBuilder WithError(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("error", alias, new GraphQlDirective?[] { include, skip });
        public ImportDocFromHTMLResultQueryBuilder ExceptError() =>
            ExceptField("error");
    }
}
