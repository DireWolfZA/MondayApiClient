using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormQuestionOptionQueryBuilder : GraphQlQueryBuilder<FormQuestionOptionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "label" }
        };

        protected override string TypeName => "FormQuestionOption";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormQuestionOptionQueryBuilder WithLabel(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("label", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionOptionQueryBuilder ExceptLabel() =>
            ExceptField("label");
    }
}
