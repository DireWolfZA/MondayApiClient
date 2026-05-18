using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TranscriptEntryQueryBuilder : GraphQlQueryBuilder<TranscriptEntryQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "start_time" },
            new GraphQlFieldMetadata { Name = "end_time" },
            new GraphQlFieldMetadata { Name = "speaker" },
            new GraphQlFieldMetadata { Name = "language" }
        };

        protected override string TypeName => "TranscriptEntry";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TranscriptEntryQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public TranscriptEntryQueryBuilder ExceptText() =>
            ExceptField("text");
        public TranscriptEntryQueryBuilder WithStartTime(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("start_time", alias, new GraphQlDirective?[] { include, skip });
        public TranscriptEntryQueryBuilder ExceptStartTime() =>
            ExceptField("start_time");
        public TranscriptEntryQueryBuilder WithEndTime(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("end_time", alias, new GraphQlDirective?[] { include, skip });
        public TranscriptEntryQueryBuilder ExceptEndTime() =>
            ExceptField("end_time");
        public TranscriptEntryQueryBuilder WithSpeaker(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("speaker", alias, new GraphQlDirective?[] { include, skip });
        public TranscriptEntryQueryBuilder ExceptSpeaker() =>
            ExceptField("speaker");
        public TranscriptEntryQueryBuilder WithLanguage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("language", alias, new GraphQlDirective?[] { include, skip });
        public TranscriptEntryQueryBuilder ExceptLanguage() =>
            ExceptField("language");
    }
}
