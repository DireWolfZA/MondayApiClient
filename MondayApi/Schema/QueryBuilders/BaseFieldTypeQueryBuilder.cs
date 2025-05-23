using System.Collections.Generic;

namespace MondayApi.Schema {
    public class BaseFieldTypeQueryBuilder : GraphQlQueryBuilder<BaseFieldTypeQueryBuilder> {
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

        protected override string TypeName => "BaseFieldType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public BaseFieldTypeQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public BaseFieldTypeQueryBuilder ExceptID() =>
            ExceptField("id");
        public BaseFieldTypeQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public BaseFieldTypeQueryBuilder ExceptName() =>
            ExceptField("name");
        public BaseFieldTypeQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public BaseFieldTypeQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public BaseFieldTypeQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public BaseFieldTypeQueryBuilder ExceptState() =>
            ExceptField("state");
        public BaseFieldTypeQueryBuilder WithKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("key", alias, new GraphQlDirective?[] { include, skip });
        public BaseFieldTypeQueryBuilder ExceptKey() =>
            ExceptField("key");
        public BaseFieldTypeQueryBuilder WithDefaultFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("defaultFieldKey", alias, new GraphQlDirective?[] { include, skip });
        public BaseFieldTypeQueryBuilder ExceptDefaultFieldKey() =>
            ExceptField("defaultFieldKey");
        public BaseFieldTypeQueryBuilder WithDependencyConfig(DependencyConfigQueryBuilder dependencyConfigQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("dependencyConfig", alias, dependencyConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BaseFieldTypeQueryBuilder ExceptDependencyConfig() =>
            ExceptField("dependencyConfig");
        public BaseFieldTypeQueryBuilder WithImplement(FieldTypeImplementationQueryBuilder fieldTypeImplementationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("implement", alias, fieldTypeImplementationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public BaseFieldTypeQueryBuilder ExceptImplement() =>
            ExceptField("implement");
    }
}
