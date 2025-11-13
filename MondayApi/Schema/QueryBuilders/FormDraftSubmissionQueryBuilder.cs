using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormDraftSubmissionQueryBuilder : GraphQlQueryBuilder<FormDraftSubmissionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" }
        };

        protected override string TypeName => "FormDraftSubmission";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormDraftSubmissionQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public FormDraftSubmissionQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
    }
}
