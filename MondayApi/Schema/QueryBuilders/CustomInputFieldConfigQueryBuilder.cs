using System.Collections.Generic;

namespace MondayApi.Schema {
    public class CustomInputFieldConfigQueryBuilder : GraphQlQueryBuilder<CustomInputFieldConfigQueryBuilder> {
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
            new GraphQlFieldMetadata { Name = "fieldTypeReferenceId" },
            new GraphQlFieldMetadata { Name = "constraints", IsComplex = true, QueryBuilderType = typeof(InputFieldConstraintsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "fieldTypeData", IsComplex = true, QueryBuilderType = typeof(FieldTypeQueryBuilder) }
        };

        protected override string TypeName => "CustomInputFieldConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public CustomInputFieldConfigQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptID() =>
            ExceptField("id");
        public CustomInputFieldConfigQueryBuilder WithFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldKey", alias, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptFieldKey() =>
            ExceptField("fieldKey");
        public CustomInputFieldConfigQueryBuilder WithFieldTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTitle", alias, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptFieldTitle() =>
            ExceptField("fieldTitle");
        public CustomInputFieldConfigQueryBuilder WithIsNullable(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isNullable", alias, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptIsNullable() =>
            ExceptField("isNullable");
        public CustomInputFieldConfigQueryBuilder WithIsArray(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isArray", alias, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptIsArray() =>
            ExceptField("isArray");
        public CustomInputFieldConfigQueryBuilder WithIsOptional(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isOptional", alias, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptIsOptional() =>
            ExceptField("isOptional");
        public CustomInputFieldConfigQueryBuilder WithInformation(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("information", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptInformation() =>
            ExceptField("information");
        public CustomInputFieldConfigQueryBuilder WithDescription(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("description", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public CustomInputFieldConfigQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptType() =>
            ExceptField("type");
        public CustomInputFieldConfigQueryBuilder WithFieldTypeReferenceID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTypeReferenceId", alias, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptFieldTypeReferenceID() =>
            ExceptField("fieldTypeReferenceId");
        public CustomInputFieldConfigQueryBuilder WithConstraints(InputFieldConstraintsQueryBuilder inputFieldConstraintsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("constraints", alias, inputFieldConstraintsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptConstraints() =>
            ExceptField("constraints");
        public CustomInputFieldConfigQueryBuilder WithFieldTypeData(FieldTypeQueryBuilder fieldTypeQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("fieldTypeData", alias, fieldTypeQueryBuilder, new GraphQlDirective?[] { include, skip });
        public CustomInputFieldConfigQueryBuilder ExceptFieldTypeData() =>
            ExceptField("fieldTypeData");
    }
}
