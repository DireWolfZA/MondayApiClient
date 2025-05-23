using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PrimitiveOutputFieldConfigQueryBuilder : GraphQlQueryBuilder<PrimitiveOutputFieldConfigQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "fieldKey" },
            new GraphQlFieldMetadata { Name = "fieldTitle" },
            new GraphQlFieldMetadata { Name = "isNullable" },
            new GraphQlFieldMetadata { Name = "isArray" },
            new GraphQlFieldMetadata { Name = "isOptional" },
            new GraphQlFieldMetadata { Name = "information", IsComplex = true, QueryBuilderType = typeof(FieldInformationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "description", IsComplex = true, QueryBuilderType = typeof(FieldInformationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "primitiveType" }
        };

        protected override string TypeName => "PrimitiveOutputFieldConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PrimitiveOutputFieldConfigQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptID() =>
            ExceptField("id");
        public PrimitiveOutputFieldConfigQueryBuilder WithFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldKey", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptFieldKey() =>
            ExceptField("fieldKey");
        public PrimitiveOutputFieldConfigQueryBuilder WithFieldTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTitle", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptFieldTitle() =>
            ExceptField("fieldTitle");
        public PrimitiveOutputFieldConfigQueryBuilder WithIsNullable(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isNullable", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptIsNullable() =>
            ExceptField("isNullable");
        public PrimitiveOutputFieldConfigQueryBuilder WithIsArray(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isArray", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptIsArray() =>
            ExceptField("isArray");
        public PrimitiveOutputFieldConfigQueryBuilder WithIsOptional(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isOptional", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptIsOptional() =>
            ExceptField("isOptional");
        public PrimitiveOutputFieldConfigQueryBuilder WithInformation(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("information", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptInformation() =>
            ExceptField("information");
        public PrimitiveOutputFieldConfigQueryBuilder WithDescription(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("description", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public PrimitiveOutputFieldConfigQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptType() =>
            ExceptField("type");
        public PrimitiveOutputFieldConfigQueryBuilder WithPrimitiveType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("primitiveType", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveOutputFieldConfigQueryBuilder ExceptPrimitiveType() =>
            ExceptField("primitiveType");
    }
}
