using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormMondayQueryBuilder : GraphQlQueryBuilder<FormMondayQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "itemGroupId" },
            new GraphQlFieldMetadata { Name = "includeNameQuestion" },
            new GraphQlFieldMetadata { Name = "includeUpdateQuestion" },
            new GraphQlFieldMetadata { Name = "syncQuestionAndColumnsTitles" }
        };

        protected override string TypeName => "FormMonday";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormMondayQueryBuilder WithItemGroupID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("itemGroupId", alias, new GraphQlDirective?[] { include, skip });
        public FormMondayQueryBuilder ExceptItemGroupID() =>
            ExceptField("itemGroupId");
        public FormMondayQueryBuilder WithIncludeNameQuestion(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("includeNameQuestion", alias, new GraphQlDirective?[] { include, skip });
        public FormMondayQueryBuilder ExceptIncludeNameQuestion() =>
            ExceptField("includeNameQuestion");
        public FormMondayQueryBuilder WithIncludeUpdateQuestion(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("includeUpdateQuestion", alias, new GraphQlDirective?[] { include, skip });
        public FormMondayQueryBuilder ExceptIncludeUpdateQuestion() =>
            ExceptField("includeUpdateQuestion");
        public FormMondayQueryBuilder WithSyncQuestionAndColumnsTitles(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("syncQuestionAndColumnsTitles", alias, new GraphQlDirective?[] { include, skip });
        public FormMondayQueryBuilder ExceptSyncQuestionAndColumnsTitles() =>
            ExceptField("syncQuestionAndColumnsTitles");
    }
}
