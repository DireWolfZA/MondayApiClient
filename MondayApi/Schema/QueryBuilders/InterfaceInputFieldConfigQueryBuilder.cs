using System.Collections.Generic;

namespace MondayApi.Schema {
    public class InterfaceInputFieldConfigQueryBuilder : GraphQlQueryBuilder<InterfaceInputFieldConfigQueryBuilder> {
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
            new GraphQlFieldMetadata { Name = "subfieldName" },
            new GraphQlFieldMetadata { Name = "constraints", IsComplex = true, QueryBuilderType = typeof(InputFieldConstraintsQueryBuilder) }
        };

        protected override string TypeName => "InterfaceInputFieldConfig";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public InterfaceInputFieldConfigQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptID() =>
            ExceptField("id");
        public InterfaceInputFieldConfigQueryBuilder WithFieldKey(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldKey", alias, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptFieldKey() =>
            ExceptField("fieldKey");
        public InterfaceInputFieldConfigQueryBuilder WithFieldTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("fieldTitle", alias, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptFieldTitle() =>
            ExceptField("fieldTitle");
        public InterfaceInputFieldConfigQueryBuilder WithIsNullable(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isNullable", alias, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptIsNullable() =>
            ExceptField("isNullable");
        public InterfaceInputFieldConfigQueryBuilder WithIsArray(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isArray", alias, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptIsArray() =>
            ExceptField("isArray");
        public InterfaceInputFieldConfigQueryBuilder WithIsOptional(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isOptional", alias, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptIsOptional() =>
            ExceptField("isOptional");
        public InterfaceInputFieldConfigQueryBuilder WithInformation(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("information", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptInformation() =>
            ExceptField("information");
        public InterfaceInputFieldConfigQueryBuilder WithDescription(FieldInformationQueryBuilder fieldInformationQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("description", alias, fieldInformationQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public InterfaceInputFieldConfigQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptType() =>
            ExceptField("type");
        public InterfaceInputFieldConfigQueryBuilder WithSubfieldName(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("subfieldName", alias, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptSubfieldName() =>
            ExceptField("subfieldName");
        public InterfaceInputFieldConfigQueryBuilder WithConstraints(InputFieldConstraintsQueryBuilder inputFieldConstraintsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("constraints", alias, inputFieldConstraintsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public InterfaceInputFieldConfigQueryBuilder ExceptConstraints() =>
            ExceptField("constraints");
    }
}
