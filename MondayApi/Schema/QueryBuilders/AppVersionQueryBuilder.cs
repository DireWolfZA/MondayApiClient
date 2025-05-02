using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AppVersionQueryBuilder : GraphQlQueryBuilder<AppVersionQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "major" },
            new GraphQlFieldMetadata { Name = "minor" },
            new GraphQlFieldMetadata { Name = "patch" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" }
        };

        protected override string TypeName => "AppVersion";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AppVersionQueryBuilder WithMajor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("major", alias, new GraphQlDirective?[] { include, skip });
        public AppVersionQueryBuilder ExceptMajor() =>
            ExceptField("major");
        public AppVersionQueryBuilder WithMinor(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("minor", alias, new GraphQlDirective?[] { include, skip });
        public AppVersionQueryBuilder ExceptMinor() =>
            ExceptField("minor");
        public AppVersionQueryBuilder WithPatch(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("patch", alias, new GraphQlDirective?[] { include, skip });
        public AppVersionQueryBuilder ExceptPatch() =>
            ExceptField("patch");
        public AppVersionQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public AppVersionQueryBuilder ExceptText() =>
            ExceptField("text");
        public AppVersionQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public AppVersionQueryBuilder ExceptType() =>
            ExceptField("type");
    }
}
