using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SubfieldsFieldTypeQueryBuilder : GraphQlQueryBuilder<SubfieldsFieldTypeQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "name" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "state" },
            new GraphQlFieldMetadata { Name = "key" },
            new GraphQlFieldMetadata { Name = "defaultFieldKey" },
            new GraphQlFieldMetadata { Name = "dependencyConfig", IsComplex = true, QueryBuilderType = typeof(DependencyConfigQueryBuilder) },
            new GraphQlFieldMetadata { Name = "implement", IsComplex = true, QueryBuilderType = typeof(FieldTypeImplementationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "hasRemoteSubfields" }
        };

        protected override string TypeName => "SubfieldsFieldType";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SubfieldsFieldTypeQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptID() =>
            ExceptField("id");
        public SubfieldsFieldTypeQueryBuilder WithName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("name", alias, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptName() =>
            ExceptField("name");
        public SubfieldsFieldTypeQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public SubfieldsFieldTypeQueryBuilder WithState(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("state", alias, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptState() =>
            ExceptField("state");
        public SubfieldsFieldTypeQueryBuilder WithKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("key", alias, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptKey() =>
            ExceptField("key");
        public SubfieldsFieldTypeQueryBuilder WithDefaultFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("defaultFieldKey", alias, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptDefaultFieldKey() =>
            ExceptField("defaultFieldKey");
        public SubfieldsFieldTypeQueryBuilder WithDependencyConfig(DependencyConfigQueryBuilder dependencyConfigQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("dependencyConfig", alias, dependencyConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptDependencyConfig() =>
            ExceptField("dependencyConfig");
        public SubfieldsFieldTypeQueryBuilder WithImplement(FieldTypeImplementationQueryBuilder fieldTypeImplementationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("implement", alias, fieldTypeImplementationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptImplement() =>
            ExceptField("implement");
        public SubfieldsFieldTypeQueryBuilder WithHasRemoteSubfields(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("hasRemoteSubfields", alias, new GraphQlDirective?[] { include, skip });
        public SubfieldsFieldTypeQueryBuilder ExceptHasRemoteSubfields() =>
            ExceptField("hasRemoteSubfields");
    }
}
