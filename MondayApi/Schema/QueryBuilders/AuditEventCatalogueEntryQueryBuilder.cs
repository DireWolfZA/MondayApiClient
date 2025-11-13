using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AuditEventCatalogueEntryQueryBuilder : GraphQlQueryBuilder<AuditEventCatalogueEntryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "metadata_details" }
        };

        protected override string TypeName => "AuditEventCatalogueEntry";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AuditEventCatalogueEntryQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public AuditEventCatalogueEntryQueryBuilder ExceptName() =>
            ExceptField("name");
        public AuditEventCatalogueEntryQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public AuditEventCatalogueEntryQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public AuditEventCatalogueEntryQueryBuilder WithMetadataDetails(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("metadata_details", alias, new GraphQlDirective?[] { include, skip });
        public AuditEventCatalogueEntryQueryBuilder ExceptMetadataDetails() =>
            ExceptField("metadata_details");
    }
}
