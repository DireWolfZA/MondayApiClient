using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ObjectRelationQueryBuilder : GraphQlQueryBuilder<ObjectRelationQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "source_object_id" },
            new GraphQlFieldMetadata { Name = "target_id" },
            new GraphQlFieldMetadata { Name = "target_object_type" },
            new GraphQlFieldMetadata { Name = "kind" }
        };

        protected override string TypeName => "ObjectRelation";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ObjectRelationQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ObjectRelationQueryBuilder ExceptID() =>
            ExceptField("id");
        public ObjectRelationQueryBuilder WithSourceObjectID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("source_object_id", alias, new GraphQlDirective?[] { include, skip });
        public ObjectRelationQueryBuilder ExceptSourceObjectID() =>
            ExceptField("source_object_id");
        public ObjectRelationQueryBuilder WithTargetID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("target_id", alias, new GraphQlDirective?[] { include, skip });
        public ObjectRelationQueryBuilder ExceptTargetID() =>
            ExceptField("target_id");
        public ObjectRelationQueryBuilder WithTargetObjectType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("target_object_type", alias, new GraphQlDirective?[] { include, skip });
        public ObjectRelationQueryBuilder ExceptTargetObjectType() =>
            ExceptField("target_object_type");
        public ObjectRelationQueryBuilder WithKind(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("kind", alias, new GraphQlDirective?[] { include, skip });
        public ObjectRelationQueryBuilder ExceptKind() =>
            ExceptField("kind");
    }
}
