using System.Collections.Generic;

namespace MondayApi.Schema {
    public class HierarchyObjectIDQueryBuilder : GraphQlQueryBuilder<HierarchyObjectIDQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "type" }
        };

        protected override string TypeName => "HierarchyObjectID";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public HierarchyObjectIDQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public HierarchyObjectIDQueryBuilder ExceptID() =>
            ExceptField("id");
        public HierarchyObjectIDQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public HierarchyObjectIDQueryBuilder ExceptType() =>
            ExceptField("type");
    }
}
