using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ExportMarkdownResultQueryBuilder : GraphQlQueryBuilder<ExportMarkdownResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "markdown" },
            new GraphQlFieldMetadata { Name = "error" }
        };

        protected override string TypeName => "ExportMarkdownResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ExportMarkdownResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public ExportMarkdownResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public ExportMarkdownResultQueryBuilder WithMarkdown(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("markdown", alias, new GraphQlDirective?[] { include, skip });
        public ExportMarkdownResultQueryBuilder ExceptMarkdown() =>
            ExceptField("markdown");
        public ExportMarkdownResultQueryBuilder WithError(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("error", alias, new GraphQlDirective?[] { include, skip });
        public ExportMarkdownResultQueryBuilder ExceptError() =>
            ExceptField("error");
    }
}
