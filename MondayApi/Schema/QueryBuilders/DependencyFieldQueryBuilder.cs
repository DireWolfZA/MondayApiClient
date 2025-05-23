using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DependencyFieldQueryBuilder : GraphQlQueryBuilder<DependencyFieldQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "sourceFieldTypeReferenceId" },
            new GraphQlFieldMetadata { Name = "targetFieldKey" }
        };

        protected override string TypeName => "DependencyField";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DependencyFieldQueryBuilder WithSourceFieldTypeReferenceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("sourceFieldTypeReferenceId", alias, new GraphQlDirective?[] { include, skip });
        public DependencyFieldQueryBuilder ExceptSourceFieldTypeReferenceID() =>
            ExceptField("sourceFieldTypeReferenceId");
        public DependencyFieldQueryBuilder WithTargetFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("targetFieldKey", alias, new GraphQlDirective?[] { include, skip });
        public DependencyFieldQueryBuilder ExceptTargetFieldKey() =>
            ExceptField("targetFieldKey");
    }
}
