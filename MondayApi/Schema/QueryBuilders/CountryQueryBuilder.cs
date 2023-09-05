using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CountryQueryBuilder : GraphQlQueryBuilder<CountryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "code" },
            new GraphQlFieldMetadata { Name = "name" }
        };

        protected override string TypeName => "Country";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CountryQueryBuilder WithCode(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("code", alias, new GraphQlDirective[] { include, skip });
        public CountryQueryBuilder ExceptCode() =>
            ExceptField("code");
        public CountryQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        public CountryQueryBuilder ExceptName() =>
            ExceptField("name");
    }
}
