using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FieldTypeQueryBuilder : GraphQlQueryBuilder<FieldTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "key" },
            new GraphQlFieldMetadata { Name = "defaultFieldKey" },
            new GraphQlFieldMetadata { Name = "dependencyConfig", IsComplex = true, QueryBuilderType = typeof(DependencyConfigQueryBuilder) },
            new GraphQlFieldMetadata { Name = "implement", IsComplex = true, QueryBuilderType = typeof(FieldTypeImplementationQueryBuilder) }
        };

        public FieldTypeQueryBuilder() => WithTypeName();
        protected override string TypeName => "FieldType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FieldTypeQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder ExceptID() =>
            ExceptField("id");
        public FieldTypeQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder ExceptName() =>
            ExceptField("name");
        public FieldTypeQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public FieldTypeQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder ExceptState() =>
            ExceptField("state");
        public FieldTypeQueryBuilder WithKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("key", alias, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder ExceptKey() =>
            ExceptField("key");
        public FieldTypeQueryBuilder WithDefaultFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("defaultFieldKey", alias, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder ExceptDefaultFieldKey() =>
            ExceptField("defaultFieldKey");
        public FieldTypeQueryBuilder WithDependencyConfig(DependencyConfigQueryBuilder dependencyConfigQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("dependencyConfig", alias, dependencyConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder ExceptDependencyConfig() =>
            ExceptField("dependencyConfig");
        public FieldTypeQueryBuilder WithImplement(FieldTypeImplementationQueryBuilder fieldTypeImplementationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("implement", alias, fieldTypeImplementationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder ExceptImplement() =>
            ExceptField("implement");
        public FieldTypeQueryBuilder WithBaseFieldTypeFragment(BaseFieldTypeQueryBuilder baseFieldTypeQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(baseFieldTypeQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder WithPrimitiveFieldTypeFragment(PrimitiveFieldTypeQueryBuilder primitiveFieldTypeQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(primitiveFieldTypeQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FieldTypeQueryBuilder WithSubfieldsFieldTypeFragment(SubfieldsFieldTypeQueryBuilder subfieldsFieldTypeQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(subfieldsFieldTypeQueryBuilder, new GraphQlDirective?[] { include, skip });
    }
}
