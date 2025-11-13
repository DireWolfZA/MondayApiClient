using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PhonePrefixPredefinedQueryBuilder : GraphQlQueryBuilder<PhonePrefixPredefinedQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "enabled" },
            new GraphQlFieldMetadata { Name = "prefix" }
        };

        protected override string TypeName => "PhonePrefixPredefined";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PhonePrefixPredefinedQueryBuilder WithEnabled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("enabled", alias, new GraphQlDirective?[] { include, skip });
        public PhonePrefixPredefinedQueryBuilder ExceptEnabled() =>
            ExceptField("enabled");
        public PhonePrefixPredefinedQueryBuilder WithPrefix(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("prefix", alias, new GraphQlDirective?[] { include, skip });
        public PhonePrefixPredefinedQueryBuilder ExceptPrefix() =>
            ExceptField("prefix");
    }
}
