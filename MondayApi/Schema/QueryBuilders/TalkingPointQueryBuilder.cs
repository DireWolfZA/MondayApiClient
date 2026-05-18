using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TalkingPointQueryBuilder : GraphQlQueryBuilder<TalkingPointQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "content" },
            new GraphQlFieldMetadata { Name = "timestamp" }
        };

        protected override string TypeName => "TalkingPoint";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TalkingPointQueryBuilder WithContent(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("content", alias, new GraphQlDirective?[] { include, skip });
        public TalkingPointQueryBuilder ExceptContent() =>
            ExceptField("content");
        public TalkingPointQueryBuilder WithTimestamp(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("timestamp", alias, new GraphQlDirective?[] { include, skip });
        public TalkingPointQueryBuilder ExceptTimestamp() =>
            ExceptField("timestamp");
    }
}
