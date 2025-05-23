using System.Collections.Generic;

namespace MondayApi.Schema {
    public class PrimitiveInputFieldConfigQueryBuilder : GraphQlQueryBuilder<PrimitiveInputFieldConfigQueryBuilder> {
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

        protected override string TypeName => "PrimitiveInputFieldConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public PrimitiveInputFieldConfigQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptID() =>
            ExceptField("id");
        public PrimitiveInputFieldConfigQueryBuilder WithFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldKey", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptFieldKey() =>
            ExceptField("fieldKey");
        public PrimitiveInputFieldConfigQueryBuilder WithFieldTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTitle", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptFieldTitle() =>
            ExceptField("fieldTitle");
        public PrimitiveInputFieldConfigQueryBuilder WithIsNullable(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isNullable", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptIsNullable() =>
            ExceptField("isNullable");
        public PrimitiveInputFieldConfigQueryBuilder WithIsArray(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isArray", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptIsArray() =>
            ExceptField("isArray");
        public PrimitiveInputFieldConfigQueryBuilder WithIsOptional(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isOptional", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptIsOptional() =>
            ExceptField("isOptional");
        public PrimitiveInputFieldConfigQueryBuilder WithInformation(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("information", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptInformation() =>
            ExceptField("information");
        public PrimitiveInputFieldConfigQueryBuilder WithDescription(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("description", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public PrimitiveInputFieldConfigQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptType() =>
            ExceptField("type");
        public PrimitiveInputFieldConfigQueryBuilder WithPrimitiveType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("primitiveType", alias, new GraphQlDirective?[] { include, skip });
        public PrimitiveInputFieldConfigQueryBuilder ExceptPrimitiveType() =>
            ExceptField("primitiveType");
    }
}
