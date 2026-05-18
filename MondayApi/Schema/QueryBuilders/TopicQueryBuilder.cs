using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TopicQueryBuilder : GraphQlQueryBuilder<TopicQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "talking_points", IsComplex = true, QueryBuilderType = typeof(TalkingPointQueryBuilder) }
        };

        protected override string TypeName => "Topic";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TopicQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public TopicQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public TopicQueryBuilder WithTalkingPoints(TalkingPointQueryBuilder talkingPointQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("talking_points", alias, talkingPointQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TopicQueryBuilder ExceptTalkingPoints() =>
            ExceptField("talking_points");
    }
}
