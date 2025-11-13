using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormTagQueryBuilder : GraphQlQueryBuilder<FormTagQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "value" },
            new GraphQlFieldMetadata { Name = "columnId" }
        };

        protected override string TypeName => "FormTag";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormTagQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public FormTagQueryBuilder ExceptID() =>
            ExceptField("id");
        public FormTagQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public FormTagQueryBuilder ExceptName() =>
            ExceptField("name");
        public FormTagQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public FormTagQueryBuilder ExceptValue() =>
            ExceptField("value");
        public FormTagQueryBuilder WithColumnID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("columnId", alias, new GraphQlDirective?[] { include, skip });
        public FormTagQueryBuilder ExceptColumnID() =>
            ExceptField("columnId");
    }
}
