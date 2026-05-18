using System.Collections.Generic;

namespace MondayApi.Schema {
    public class EnrollToSequenceResultQueryBuilder : GraphQlQueryBuilder<EnrollToSequenceResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "succeeded_item_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "failed_item_ids", IsComplex = true }
        };

        protected override string TypeName => "EnrollToSequenceResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public EnrollToSequenceResultQueryBuilder WithSucceededItemIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("succeeded_item_ids", alias, new GraphQlDirective?[] { include, skip });
        public EnrollToSequenceResultQueryBuilder ExceptSucceededItemIDs() =>
            ExceptField("succeeded_item_ids");
        public EnrollToSequenceResultQueryBuilder WithFailedItemIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("failed_item_ids", alias, new GraphQlDirective?[] { include, skip });
        public EnrollToSequenceResultQueryBuilder ExceptFailedItemIDs() =>
            ExceptField("failed_item_ids");
    }
}
