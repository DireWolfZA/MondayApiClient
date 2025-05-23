using System.Collections.Generic;

namespace MondayApi.Schema {
    public class InputFieldConfigQueryBuilder : GraphQlQueryBuilder<InputFieldConfigQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "fieldKey" },
            new GraphQlFieldMetadata { Name = "fieldTitle" },
            new GraphQlFieldMetadata { Name = "isNullable" },
            new GraphQlFieldMetadata { Name = "isArray" },
            new GraphQlFieldMetadata { Name = "isOptional" },
            new GraphQlFieldMetadata { Name = "information", IsComplex = true, QueryBuilderType = typeof(FieldInformationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "description", IsComplex = true, QueryBuilderType = typeof(FieldInformationQueryBuilder) },
            new GraphQlFieldMetadata { Name = "type" }
        };

        public InputFieldConfigQueryBuilder() => WithTypeName();
        protected override string TypeName => "InputFieldConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public InputFieldConfigQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptID() =>
            ExceptField("id");
        public InputFieldConfigQueryBuilder WithFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldKey", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptFieldKey() =>
            ExceptField("fieldKey");
        public InputFieldConfigQueryBuilder WithFieldTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTitle", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptFieldTitle() =>
            ExceptField("fieldTitle");
        public InputFieldConfigQueryBuilder WithIsNullable(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isNullable", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptIsNullable() =>
            ExceptField("isNullable");
        public InputFieldConfigQueryBuilder WithIsArray(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isArray", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptIsArray() =>
            ExceptField("isArray");
        public InputFieldConfigQueryBuilder WithIsOptional(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isOptional", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptIsOptional() =>
            ExceptField("isOptional");
        public InputFieldConfigQueryBuilder WithInformation(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("information", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptInformation() =>
            ExceptField("information");
        public InputFieldConfigQueryBuilder WithDescription(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("description", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public InputFieldConfigQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder ExceptType() =>
            ExceptField("type");
        public InputFieldConfigQueryBuilder WithCustomInputFieldConfigFragment(CustomInputFieldConfigQueryBuilder customInputFieldConfigQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(customInputFieldConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder WithInterfaceInputFieldConfigFragment(InterfaceInputFieldConfigQueryBuilder interfaceInputFieldConfigQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(interfaceInputFieldConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InputFieldConfigQueryBuilder WithPrimitiveInputFieldConfigFragment(PrimitiveInputFieldConfigQueryBuilder primitiveInputFieldConfigQueryBuilder, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithFragment(primitiveInputFieldConfigQueryBuilder, new GraphQlDirective?[] { include, skip });
    }
}
