using System.Collections.Generic;

namespace MondayApi.Schema {
    public class VoteValueQueryBuilder : GraphQlQueryBuilder<VoteValueQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "column", IsComplex = true, QueryBuilderType = typeof(ColumnQueryBuilder) },
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "text" },
            new GraphQlFieldMetadata { Name = "type" },
            new GraphQlFieldMetadata { Name = "updated_at" },
            new GraphQlFieldMetadata { Name = "value" },
            new GraphQlFieldMetadata { Name = "vote_count" },
            new GraphQlFieldMetadata { Name = "voter_ids", IsComplex = true },
            new GraphQlFieldMetadata { Name = "voters", IsComplex = true, QueryBuilderType = typeof(UserQueryBuilder) }
        };

        protected override string TypeName => "VoteValue";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public VoteValueQueryBuilder WithColumn(ColumnQueryBuilder columnQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("column", alias, columnQueryBuilder, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptColumn() =>
            ExceptField("column");
        public VoteValueQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptID() =>
            ExceptField("id");
        public VoteValueQueryBuilder WithText(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("text", alias, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptText() =>
            ExceptField("text");
        public VoteValueQueryBuilder WithType(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("type", alias, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptType() =>
            ExceptField("type");
        public VoteValueQueryBuilder WithUpdatedAt(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("updated_at", alias, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptUpdatedAt() =>
            ExceptField("updated_at");
        public VoteValueQueryBuilder WithValue(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("value", alias, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptValue() =>
            ExceptField("value");
        public VoteValueQueryBuilder WithVoteCount(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("vote_count", alias, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptVoteCount() =>
            ExceptField("vote_count");
        public VoteValueQueryBuilder WithVoterIDs(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("voter_ids", alias, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptVoterIDs() =>
            ExceptField("voter_ids");
        public VoteValueQueryBuilder WithVoters(UserQueryBuilder userQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("voters", alias, userQueryBuilder, new GraphQlDirective?[] { include, skip });
        public VoteValueQueryBuilder ExceptVoters() =>
            ExceptField("voters");
    }
}
