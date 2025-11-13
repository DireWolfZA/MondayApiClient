using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormPreSubmissionViewQueryBuilder : GraphQlQueryBuilder<FormPreSubmissionViewQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "startButton", IsComplex = true, QueryBuilderType = typeof(FormStartButtonQueryBuilder) }
        };

        protected override string TypeName => "FormPreSubmissionView";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormPreSubmissionViewQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public FormPreSubmissionViewQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public FormPreSubmissionViewQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public FormPreSubmissionViewQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public FormPreSubmissionViewQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public FormPreSubmissionViewQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public FormPreSubmissionViewQueryBuilder WithStartButton(FormStartButtonQueryBuilder formStartButtonQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("startButton", alias, formStartButtonQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormPreSubmissionViewQueryBuilder ExceptStartButton() =>
            ExceptField("startButton");
    }
}
