using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FieldTypeImplementationQueryBuilder : GraphQlQueryBuilder<FieldTypeImplementationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" }
        };

        protected override string TypeName => "FieldTypeImplementation";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FieldTypeImplementationQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public FieldTypeImplementationQueryBuilder ExceptID() =>
            ExceptField("id");
        public FieldTypeImplementationQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public FieldTypeImplementationQueryBuilder ExceptName() =>
            ExceptField("name");
    }
}
