using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ValidationsQueryBuilder : GraphQlQueryBuilder<ValidationsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "required_column_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "rules" }
        };

        protected override string TypeName => "Validations";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ValidationsQueryBuilder WithRequiredColumnIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("required_column_ids", alias, new GraphQlDirective?[] { include, skip });
        public ValidationsQueryBuilder ExceptRequiredColumnIDs() =>
            ExceptField("required_column_ids");
        public ValidationsQueryBuilder WithRules(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("rules", alias, new GraphQlDirective?[] { include, skip });
        public ValidationsQueryBuilder ExceptRules() =>
            ExceptField("rules");
    }
}
