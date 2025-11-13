using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormQuestionQueryBuilder : GraphQlQueryBuilder<FormQuestionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "visible" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "required" },
            new GraphQlFieldMetadata { Name = "settings", IsComplex = true, QueryBuilderType = typeof(FormQuestionSettingsQueryBuilder) },
            new GraphQlFieldMetadata { Name = "options", IsComplex = true, QueryBuilderType = typeof(FormQuestionOptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "showIfRules" }
        };

        protected override string TypeName => "FormQuestion";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormQuestionQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptID() =>
            ExceptField("id");
        public FormQuestionQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptType() =>
            ExceptField("type");
        public FormQuestionQueryBuilder WithVisible(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("visible", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptVisible() =>
            ExceptField("visible");
        public FormQuestionQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public FormQuestionQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public FormQuestionQueryBuilder WithRequired(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("required", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptRequired() =>
            ExceptField("required");
        public FormQuestionQueryBuilder WithSettings(FormQuestionSettingsQueryBuilder formQuestionSettingsQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("settings", alias, formQuestionSettingsQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptSettings() =>
            ExceptField("settings");
        public FormQuestionQueryBuilder WithOptions(FormQuestionOptionQueryBuilder formQuestionOptionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("options", alias, formQuestionOptionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptOptions() =>
            ExceptField("options");
        public FormQuestionQueryBuilder WithShowIfRules(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("showIfRules", alias, new GraphQlDirective?[] { include, skip });
        public FormQuestionQueryBuilder ExceptShowIfRules() =>
            ExceptField("showIfRules");
    }
}
