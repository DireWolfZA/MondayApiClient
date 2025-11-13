using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ResponseFormQueryBuilder : GraphQlQueryBuilder<ResponseFormQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "token" },
            new GraphQlFieldMetadata { Name = "active" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "ownerId" },
            new GraphQlFieldMetadata { Name = "builtWithAI" },
            new GraphQlFieldMetadata { Name = "description" },
            new GraphQlFieldMetadata { Name = "questions", IsComplex = true, QueryBuilderType = typeof(FormQuestionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "isAnonymous" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "features", IsComplex = true, QueryBuilderType = typeof(FormFeaturesQueryBuilder) },
            new GraphQlFieldMetadata { Name = "appearance", IsComplex = true, QueryBuilderType = typeof(FormAppearanceQueryBuilder) },
            new GraphQlFieldMetadata { Name = "accessibility", IsComplex = true, QueryBuilderType = typeof(FormAccessibilityQueryBuilder) },
            new GraphQlFieldMetadata { Name = "tags", IsComplex = true, QueryBuilderType = typeof(FormTagQueryBuilder) }
        };

        protected override string TypeName => "ResponseForm";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ResponseFormQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptID() =>
            ExceptField("id");
        public ResponseFormQueryBuilder WithToken(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("token", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptToken() =>
            ExceptField("token");
        public ResponseFormQueryBuilder WithActive(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("active", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptActive() =>
            ExceptField("active");
        public ResponseFormQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public ResponseFormQueryBuilder WithOwnerID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("ownerId", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptOwnerID() =>
            ExceptField("ownerId");
        public ResponseFormQueryBuilder WithBuiltWithAI(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("builtWithAI", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptBuiltWithAI() =>
            ExceptField("builtWithAI");
        public ResponseFormQueryBuilder WithDescription(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("description", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptDescription() =>
            ExceptField("description");
        public ResponseFormQueryBuilder WithQuestions(FormQuestionQueryBuilder formQuestionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("questions", alias, formQuestionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptQuestions() =>
            ExceptField("questions");
        public ResponseFormQueryBuilder WithIsAnonymous(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isAnonymous", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptIsAnonymous() =>
            ExceptField("isAnonymous");
        public ResponseFormQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptType() =>
            ExceptField("type");
        public ResponseFormQueryBuilder WithFeatures(FormFeaturesQueryBuilder formFeaturesQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("features", alias, formFeaturesQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptFeatures() =>
            ExceptField("features");
        public ResponseFormQueryBuilder WithAppearance(FormAppearanceQueryBuilder formAppearanceQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("appearance", alias, formAppearanceQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptAppearance() =>
            ExceptField("appearance");
        public ResponseFormQueryBuilder WithAccessibility(FormAccessibilityQueryBuilder formAccessibilityQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("accessibility", alias, formAccessibilityQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptAccessibility() =>
            ExceptField("accessibility");
        public ResponseFormQueryBuilder WithTags(FormTagQueryBuilder formTagQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("tags", alias, formTagQueryBuilder, new GraphQlDirective?[] { include, skip });
        public ResponseFormQueryBuilder ExceptTags() =>
            ExceptField("tags");
    }
}
