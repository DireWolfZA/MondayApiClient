using System.Collections.Generic;

namespace MondayApi.Schema {
    public class KnowledgeBaseAnswerQueryBuilder : GraphQlQueryBuilder<KnowledgeBaseAnswerQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "raw_snippets", IsComplex = true, QueryBuilderType = typeof(SnippetSearchResultQueryBuilder) },
            new GraphQlFieldMetadata { Name = "answer" }
        };

        protected override string TypeName => "KnowledgeBaseAnswer";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public KnowledgeBaseAnswerQueryBuilder WithRawSnippets(SnippetSearchResultQueryBuilder snippetSearchResultQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("raw_snippets", alias, snippetSearchResultQueryBuilder, new GraphQlDirective?[] { include, skip });
        public KnowledgeBaseAnswerQueryBuilder ExceptRawSnippets() =>
            ExceptField("raw_snippets");
        public KnowledgeBaseAnswerQueryBuilder WithAnswer(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("answer", alias, new GraphQlDirective?[] { include, skip });
        public KnowledgeBaseAnswerQueryBuilder ExceptAnswer() =>
            ExceptField("answer");
    }
}
