using System.Collections.Generic;

namespace MondayApi.Schema {
    public class SequenceQueryBuilder : GraphQlQueryBuilder<SequenceQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "title" },
            new GraphQlFieldMetadata { Name = "status" },
            new GraphQlFieldMetadata { Name = "context_type" },
            new GraphQlFieldMetadata { Name = "context_id" },
            new GraphQlFieldMetadata { Name = "user_id" },
            new GraphQlFieldMetadata { Name = "step_count" },
            new GraphQlFieldMetadata { Name = "duration" },
            new GraphQlFieldMetadata { Name = "created_at" },
            new GraphQlFieldMetadata { Name = "updated_at" }
        };

        protected override string TypeName => "Sequence";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public SequenceQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptID() =>
            ExceptField("id");
        public SequenceQueryBuilder WithTitle(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("title", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptTitle() =>
            ExceptField("title");
        public SequenceQueryBuilder WithStatus(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("status", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptStatus() =>
            ExceptField("status");
        public SequenceQueryBuilder WithContextType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("context_type", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptContextType() =>
            ExceptField("context_type");
        public SequenceQueryBuilder WithContextID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("context_id", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptContextID() =>
            ExceptField("context_id");
        public SequenceQueryBuilder WithUserID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("user_id", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptUserID() =>
            ExceptField("user_id");
        public SequenceQueryBuilder WithStepCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("step_count", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptStepCount() =>
            ExceptField("step_count");
        public SequenceQueryBuilder WithDuration(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("duration", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptDuration() =>
            ExceptField("duration");
        public SequenceQueryBuilder WithCreatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("created_at", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptCreatedAt() =>
            ExceptField("created_at");
        public SequenceQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public SequenceQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
    }
}
