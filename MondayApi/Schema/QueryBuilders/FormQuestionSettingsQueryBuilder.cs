using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormQuestionSettingsQueryBuilder : GraphQlQueryBuilder<FormQuestionSettingsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "prefill", IsComplex = true, QueryBuilderType = typeof(PrefillSettingsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "prefixAutofilled" },
            new GraphQlFieldMetadata { Name = "prefixPredefined", IsComplex = true, QueryBuilderType = typeof(PhonePrefixPredefinedQueryBuilder) },
            new GraphQlFieldMetadata { Name = "checkedByDefault" },
            new GraphQlFieldMetadata { Name = "defaultCurrentDate" },
            new GraphQlFieldMetadata { Name = "includeTime" },
            new GraphQlFieldMetadata { Name = "display" },
            new GraphQlFieldMetadata { Name = "optionsOrder" },
            new GraphQlFieldMetadata { Name = "locationAutofilled" },
            new GraphQlFieldMetadata { Name = "limit" },
            new GraphQlFieldMetadata { Name = "skipValidation" }
        };

        protected override string TypeName => "FormQuestionSettings";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormQuestionSettingsQueryBuilder WithPrefill(PrefillSettingsQueryBuilder prefillSettingsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("prefill", alias, prefillSettingsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptPrefill() =>
            ExceptField("prefill");
        public FormQuestionSettingsQueryBuilder WithPrefixAutofilled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("prefixAutofilled", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptPrefixAutofilled() =>
            ExceptField("prefixAutofilled");
        public FormQuestionSettingsQueryBuilder WithPrefixPredefined(PhonePrefixPredefinedQueryBuilder phonePrefixPredefinedQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("prefixPredefined", alias, phonePrefixPredefinedQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptPrefixPredefined() =>
            ExceptField("prefixPredefined");
        public FormQuestionSettingsQueryBuilder WithCheckedByDefault(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("checkedByDefault", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptCheckedByDefault() =>
            ExceptField("checkedByDefault");
        public FormQuestionSettingsQueryBuilder WithDefaultCurrentDate(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("defaultCurrentDate", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptDefaultCurrentDate() =>
            ExceptField("defaultCurrentDate");
        public FormQuestionSettingsQueryBuilder WithIncludeTime(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("includeTime", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptIncludeTime() =>
            ExceptField("includeTime");
        public FormQuestionSettingsQueryBuilder WithDisplay(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("display", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptDisplay() =>
            ExceptField("display");
        public FormQuestionSettingsQueryBuilder WithOptionsOrder(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("optionsOrder", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptOptionsOrder() =>
            ExceptField("optionsOrder");
        public FormQuestionSettingsQueryBuilder WithLocationAutofilled(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("locationAutofilled", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptLocationAutofilled() =>
            ExceptField("locationAutofilled");
        public FormQuestionSettingsQueryBuilder WithLimit(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("limit", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptLimit() =>
            ExceptField("limit");
        public FormQuestionSettingsQueryBuilder WithSkipValidation(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("skipValidation", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionSettingsQueryBuilder ExceptSkipValidation() =>
            ExceptField("skipValidation");
    }
}
