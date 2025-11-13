using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormAppearanceQueryBuilder : GraphQlQueryBuilder<FormAppearanceQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "hideBranding" },
            new GraphQlFieldMetadata { Name = "showProgressBar" },
            new GraphQlFieldMetadata { Name = "primaryColor" },
            new GraphQlFieldMetadata { Name = "layout", IsComplex = true, QueryBuilderType = typeof(FormLayoutQueryBuilder) },
            new GraphQlFieldMetadata { Name = "background", IsComplex = true, QueryBuilderType = typeof(FormBackgroundQueryBuilder) },
            new GraphQlFieldMetadata { Name = "text", IsComplex = true, QueryBuilderType = typeof(FormTextQueryBuilder) },
            new GraphQlFieldMetadata { Name = "logo", IsComplex = true, QueryBuilderType = typeof(FormLogoQueryBuilder) },
            new GraphQlFieldMetadata { Name = "submitButton", IsComplex = true, QueryBuilderType = typeof(FormSubmitButtonQueryBuilder) }
        };

        protected override string TypeName => "FormAppearance";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public FormAppearanceQueryBuilder WithHideBranding(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("hideBranding", alias, new GraphQlDirective?[] { include, skip });
        public FormAppearanceQueryBuilder ExceptHideBranding() =>
            ExceptField("hideBranding");
        public FormAppearanceQueryBuilder WithShowProgressBar(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("showProgressBar", alias, new GraphQlDirective?[] { include, skip });
        public FormAppearanceQueryBuilder ExceptShowProgressBar() =>
            ExceptField("showProgressBar");
        public FormAppearanceQueryBuilder WithPrimaryColor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("primaryColor", alias, new GraphQlDirective?[] { include, skip });
        public FormAppearanceQueryBuilder ExceptPrimaryColor() =>
            ExceptField("primaryColor");
        public FormAppearanceQueryBuilder WithLayout(FormLayoutQueryBuilder formLayoutQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("layout", alias, formLayoutQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormAppearanceQueryBuilder ExceptLayout() =>
            ExceptField("layout");
        public FormAppearanceQueryBuilder WithBackground(FormBackgroundQueryBuilder formBackgroundQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("background", alias, formBackgroundQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormAppearanceQueryBuilder ExceptBackground() =>
            ExceptField("background");
        public FormAppearanceQueryBuilder WithText(FormTextQueryBuilder formTextQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("text", alias, formTextQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormAppearanceQueryBuilder ExceptText() =>
            ExceptField("text");
        public FormAppearanceQueryBuilder WithLogo(FormLogoQueryBuilder formLogoQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("logo", alias, formLogoQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormAppearanceQueryBuilder ExceptLogo() =>
            ExceptField("logo");
        public FormAppearanceQueryBuilder WithSubmitButton(FormSubmitButtonQueryBuilder formSubmitButtonQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("submitButton", alias, formSubmitButtonQueryBuilder, new GraphQlDirective?[] { include, skip });
        public FormAppearanceQueryBuilder ExceptSubmitButton() =>
            ExceptField("submitButton");
    }
}
