using System.Collections.Generic;

namespace MondayApi.Schema {
    public class NotetakerQueriesQueryBuilder : GraphQlQueryBuilder<NotetakerQueriesQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "meetings", IsComplex = true, QueryBuilderType = typeof(MeetingsResponseQueryBuilder) }
        };

        protected override string TypeName => "NotetakerQueries";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public NotetakerQueriesQueryBuilder WithMeetings(MeetingsResponseQueryBuilder meetingsResponseQueryBuilder, QueryBuilderParameter<int?>? limit = null, QueryBuilderParameter<string?>? cursor = null, QueryBuilderParameter<MeetingsFilterInput?>? filters = null, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) {
            var args = new List<QueryBuilderArgumentInfo>();
            if (limit != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "limit", ArgumentValue = limit });
            if (cursor != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "cursor", ArgumentValue = cursor });
            if (filters != null)
                args.Add(new QueryBuilderArgumentInfo { ArgumentName = "filters", ArgumentValue = filters });
            return WithObjectField("meetings", alias, meetingsResponseQueryBuilder, new GraphQlDirective?[] { include, skip }, args);
        }
        public NotetakerQueriesQueryBuilder ExceptMeetings() =>
            ExceptField("meetings");
    }
}
