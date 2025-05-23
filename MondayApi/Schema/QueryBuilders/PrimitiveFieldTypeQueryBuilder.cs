using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PrimitiveFieldTypeQueryBuilder : GraphQlQueryBuilder<PrimitiveFieldTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "key" },
            new GraphQlFieldMetadata { Name = "defaultFieldKey" },
            new GraphQlFieldMetadata { Name = "dependencyConfig", IsComplex = true, QueryBuilderType = typeof(DependencyConfigQueryBuilder) },
            new GraphQlFieldMetadata { Name = "implement", IsComplex = true, QueryBuilderType = typeof(FieldTypeImplementationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "primitiveType" },
            new GraphQlFieldMetadata { Name = "configurartionMetadata" }
        };

        protected override string TypeName => "PrimitiveFieldType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PrimitiveFieldTypeQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptID() =>
            ExceptField("id");
        public PrimitiveFieldTypeQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptName() =>
            ExceptField("name");
        public PrimitiveFieldTypeQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public PrimitiveFieldTypeQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptState() =>
            ExceptField("state");
        public PrimitiveFieldTypeQueryBuilder WithKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("key", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptKey() =>
            ExceptField("key");
        public PrimitiveFieldTypeQueryBuilder WithDefaultFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("defaultFieldKey", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptDefaultFieldKey() =>
            ExceptField("defaultFieldKey");
        public PrimitiveFieldTypeQueryBuilder WithDependencyConfig(DependencyConfigQueryBuilder dependencyConfigQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("dependencyConfig", alias, dependencyConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptDependencyConfig() =>
            ExceptField("dependencyConfig");
        public PrimitiveFieldTypeQueryBuilder WithImplement(FieldTypeImplementationQueryBuilder fieldTypeImplementationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("implement", alias, fieldTypeImplementationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptImplement() =>
            ExceptField("implement");
        public PrimitiveFieldTypeQueryBuilder WithPrimitiveType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("primitiveType", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptPrimitiveType() =>
            ExceptField("primitiveType");
        public PrimitiveFieldTypeQueryBuilder WithConfigurartionMetadata(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("configurartionMetadata", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveFieldTypeQueryBuilder ExceptConfigurartionMetadata() =>
            ExceptField("configurartionMetadata");
    }
}
