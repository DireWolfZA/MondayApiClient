using System.Collections.Generic;

namespace MondayApi.Schema {
    public class OptionQueryBuilder : GraphQlQueryBuilder<OptionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "value" },
            new GraphQlFieldMetadata { Name = "title" }
        };

        protected override string TypeName => "Option";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public OptionQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public OptionQueryBuilder ExceptValue() =>
            ExceptField("value");
        public OptionQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public OptionQueryBuilder ExceptTitle() =>
            ExceptField("title");
    }
}
