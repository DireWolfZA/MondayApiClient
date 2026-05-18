using System.Collections.Generic;

namespace MondayApi.Schema {
    public class MeetingQueryBuilder : GraphQlQueryBuilder<MeetingQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "start_time" },
            new GraphQlFieldMetadata { Name = "end_time" },
            new GraphQlFieldMetadata { Name = "recording_duration" },
            new GraphQlFieldMetadata { Name = "access_type" },
            new GraphQlFieldMetadata { Name = "meeting_link" },
            new GraphQlFieldMetadata { Name = "participants", IsComplex = true, QueryBuilderType = typeof(ParticipantQueryBuilder) },
            new GraphQlFieldMetadata { Name = "summary" },
            new GraphQlFieldMetadata { Name = "topics", IsComplex = true, QueryBuilderType = typeof(TopicQueryBuilder) },
            new GraphQlFieldMetadata { Name = "action_items", IsComplex = true, QueryBuilderType = typeof(ActionItemQueryBuilder) },
            new GraphQlFieldMetadata { Name = "transcript", IsComplex = true, QueryBuilderType = typeof(TranscriptEntryQueryBuilder) }
        };

        protected override string TypeName => "Meeting";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public MeetingQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptID() =>
            ExceptField("id");
        public MeetingQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public MeetingQueryBuilder WithStartTime(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("start_time", alias, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptStartTime() =>
            ExceptField("start_time");
        public MeetingQueryBuilder WithEndTime(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("end_time", alias, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptEndTime() =>
            ExceptField("end_time");
        public MeetingQueryBuilder WithRecordingDuration(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("recording_duration", alias, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptRecordingDuration() =>
            ExceptField("recording_duration");
        public MeetingQueryBuilder WithAccessType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("access_type", alias, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptAccessType() =>
            ExceptField("access_type");
        public MeetingQueryBuilder WithMeetingLink(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("meeting_link", alias, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptMeetingLink() =>
            ExceptField("meeting_link");
        public MeetingQueryBuilder WithParticipants(ParticipantQueryBuilder participantQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("participants", alias, participantQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptParticipants() =>
            ExceptField("participants");
        public MeetingQueryBuilder WithSummary(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("summary", alias, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptSummary() =>
            ExceptField("summary");
        public MeetingQueryBuilder WithTopics(TopicQueryBuilder topicQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("topics", alias, topicQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptTopics() =>
            ExceptField("topics");
        public MeetingQueryBuilder WithActionItems(ActionItemQueryBuilder actionItemQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("action_items", alias, actionItemQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptActionItems() =>
            ExceptField("action_items");
        public MeetingQueryBuilder WithTranscript(TranscriptEntryQueryBuilder transcriptEntryQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("transcript", alias, transcriptEntryQueryBuilder, new GraphQlDirective?[] { include, skip });
        public MeetingQueryBuilder ExceptTranscript() =>
            ExceptField("transcript");
    }
}
