using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormResponseLimitQueryBuilder : GraphQlQueryBuilder<FormResponseLimitQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "limit" }
        };

        protected override string TypeName => "FormResponseLimit";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormResponseLimitQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public FormResponseLimitQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public FormResponseLimitQueryBuilder WithLimit(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("limit", alias, new GraphQlDirective?[] { include, skip });
        public FormResponseLimitQueryBuilder ExceptLimit() =>
            ExceptField("limit");
    }
}
