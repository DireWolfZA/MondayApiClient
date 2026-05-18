using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppDocumentationAIResponseQueryBuilder : GraphQlQueryBuilder<AppDocumentationAIResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "question" },
            new GraphQlFieldMetadata { Name = "answer" },
            new GraphQlFieldMetadata { Name = "conversation_id" }
        };

        protected override string TypeName => "AppDocumentationAiResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppDocumentationAIResponseQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public AppDocumentationAIResponseQueryBuilder ExceptID() =>
            ExceptField("id");
        public AppDocumentationAIResponseQueryBuilder WithQuestion(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("question", alias, new GraphQlDirective?[] { include, skip });
        public AppDocumentationAIResponseQueryBuilder ExceptQuestion() =>
            ExceptField("question");
        public AppDocumentationAIResponseQueryBuilder WithAnswer(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("answer", alias, new GraphQlDirective?[] { include, skip });
        public AppDocumentationAIResponseQueryBuilder ExceptAnswer() =>
            ExceptField("answer");
        public AppDocumentationAIResponseQueryBuilder WithConversationID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("conversation_id", alias, new GraphQlDirective?[] { include, skip });
        public AppDocumentationAIResponseQueryBuilder ExceptConversationID() =>
            ExceptField("conversation_id");
    }
}
