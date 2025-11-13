using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormPasswordQueryBuilder : GraphQlQueryBuilder<FormPasswordQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" }
        };

        protected override string TypeName => "FormPassword";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormPasswordQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public FormPasswordQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
    }
}
