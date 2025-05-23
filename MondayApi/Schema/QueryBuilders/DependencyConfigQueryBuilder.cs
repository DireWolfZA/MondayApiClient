using System.Collections.Generic;

namespace MondayApi.Schema {
    public class DependencyConfigQueryBuilder : GraphQlQueryBuilder<DependencyConfigQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "orderedMandatoryFields", IsComplex = true, QueryBuilderType = typeof(DependencyFieldQueryBuilder) },
            new GraphQlFieldMetadata { Name = "optionalFields", IsComplex = true, QueryBuilderType = typeof(DependencyFieldQueryBuilder) }
        };

        protected override string TypeName => "DependencyConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public DependencyConfigQueryBuilder WithOrderedMandatoryFields(DependencyFieldQueryBuilder dependencyFieldQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("orderedMandatoryFields", alias, dependencyFieldQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DependencyConfigQueryBuilder ExceptOrderedMandatoryFields() =>
            ExceptField("orderedMandatoryFields");
        public DependencyConfigQueryBuilder WithOptionalFields(DependencyFieldQueryBuilder dependencyFieldQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("optionalFields", alias, dependencyFieldQueryBuilder, new GraphQlDirective?[] { include, skip });
        public DependencyConfigQueryBuilder ExceptOptionalFields() =>
            ExceptField("optionalFields");
    }
}
