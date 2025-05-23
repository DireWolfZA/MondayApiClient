using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BlockQueryBuilder : GraphQlQueryBuilder<BlockQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "kind" },
            new GraphQlFieldMetadata { Name = "inputFieldsConfig", IsComplex = true, QueryBuilderType = typeof(InputFieldConfigQueryBuilder) },
            new GraphQlFieldMetadata { Name = "outputFieldsConfig", IsComplex = true, QueryBuilderType = typeof(OutputFieldConfigQueryBuilder) }
        };

        protected override string TypeName => "Block";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BlockQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public BlockQueryBuilder ExceptID() =>
            ExceptField("id");
        public BlockQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public BlockQueryBuilder ExceptName() =>
            ExceptField("name");
        public BlockQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public BlockQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public BlockQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public BlockQueryBuilder ExceptKind() =>
            ExceptField("kind");
        public BlockQueryBuilder WithInputFieldsConfig(InputFieldConfigQueryBuilder inputFieldConfigQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("inputFieldsConfig", alias, inputFieldConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BlockQueryBuilder ExceptInputFieldsConfig() =>
            ExceptField("inputFieldsConfig");
        public BlockQueryBuilder WithOutputFieldsConfig(OutputFieldConfigQueryBuilder outputFieldConfigQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("outputFieldsConfig", alias, outputFieldConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BlockQueryBuilder ExceptOutputFieldsConfig() =>
            ExceptField("outputFieldsConfig");
    }
}
