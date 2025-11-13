using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ObjectTypeUniqueKeyQueryBuilder : GraphQlQueryBuilder<ObjectTypeUniqueKeyQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "app_name" },
            new GraphQlFieldMetadata { Name = "app_feature_name" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "object_type_unique_key" }
        };

        protected override string TypeName => "ObjectTypeUniqueKey";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ObjectTypeUniqueKeyQueryBuilder WithAppName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("app_name", alias, new GraphQlDirective?[] { include, skip });
        public ObjectTypeUniqueKeyQueryBuilder ExceptAppName() =>
            ExceptField("app_name");
        public ObjectTypeUniqueKeyQueryBuilder WithAppFeatureName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("app_feature_name", alias, new GraphQlDirective?[] { include, skip });
        public ObjectTypeUniqueKeyQueryBuilder ExceptAppFeatureName() =>
            ExceptField("app_feature_name");
        public ObjectTypeUniqueKeyQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public ObjectTypeUniqueKeyQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public ObjectTypeUniqueKeyQueryBuilder WithObjectTypeUniqueKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("object_type_unique_key", alias, new GraphQlDirective?[] { include, skip });
        public ObjectTypeUniqueKeyQueryBuilder ExceptObjectTypeUniqueKey() =>
            ExceptField("object_type_unique_key");
    }
}
