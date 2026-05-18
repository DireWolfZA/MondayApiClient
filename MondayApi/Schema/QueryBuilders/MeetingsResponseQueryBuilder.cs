using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MeetingsResponseQueryBuilder : GraphQlQueryBuilder<MeetingsResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "meetings", IsComplex = true, QueryBuilderType = typeof(MeetingQueryBuilder) },
            new GraphQlFieldMetadata { Name = "page_info", IsComplex = true, QueryBuilderType = typeof(PageInfoQueryBuilder) }
        };

        protected override string TypeName => "MeetingsResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MeetingsResponseQueryBuilder WithMeetings(MeetingQueryBuilder meetingQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("meetings", alias, meetingQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MeetingsResponseQueryBuilder ExceptMeetings() =>
            ExceptField("meetings");
        public MeetingsResponseQueryBuilder WithPageInfo(PageInfoQueryBuilder pageInfoQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("page_info", alias, pageInfoQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MeetingsResponseQueryBuilder ExceptPageInfo() =>
            ExceptField("page_info");
    }
}
