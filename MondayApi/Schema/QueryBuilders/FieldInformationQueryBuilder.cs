using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FieldInformationQueryBuilder : GraphQlQueryBuilder<FieldInformationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "link" }
        };

        protected override string TypeName => "FieldInformation";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FieldInformationQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public FieldInformationQueryBuilder ExceptText() =>
            ExceptField("text");
        public FieldInformationQueryBuilder WithLink(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("link", alias, new GraphQlDirective?[] { include, skip });
        public FieldInformationQueryBuilder ExceptLink() =>
            ExceptField("link");
    }
}
