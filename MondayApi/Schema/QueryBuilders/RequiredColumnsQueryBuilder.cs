using System.Collections.Generic;

namespace MondayApi.Schema {
    public class RequiredColumnsQueryBuilder : GraphQlQueryBuilder<RequiredColumnsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "required_column_ids", IsComplex = true }
        };

        protected override string TypeName => "RequiredColumns";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public RequiredColumnsQueryBuilder WithRequiredColumnIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("required_column_ids", alias, new GraphQlDirective?[] { include, skip });
        public RequiredColumnsQueryBuilder ExceptRequiredColumnIDs() =>
            ExceptField("required_column_ids");
    }
}
