using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormCloseDateQueryBuilder : GraphQlQueryBuilder<FormCloseDateQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "date" }
        };

        protected override string TypeName => "FormCloseDate";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormCloseDateQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public FormCloseDateQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public FormCloseDateQueryBuilder WithDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("date", alias, new GraphQlDirective?[] { include, skip });
        public FormCloseDateQueryBuilder ExceptDate() =>
            ExceptField("date");
    }
}
