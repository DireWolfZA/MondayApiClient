using System.Collections.Generic;

namespace MondayApi.Schema {
    public class RemoveTeamOwnersResultQueryBuilder : GraphQlQueryBuilder<RemoveTeamOwnersResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "team", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "errors", IsComplex = true, QueryBuilderType = typeof(RemoveTeamOwnersErrorQueryBuilder) }
        };

        protected override string TypeName => "RemoveTeamOwnersResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public RemoveTeamOwnersResultQueryBuilder WithTeam(TeamQueryBuilder teamQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("team", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip });
        public RemoveTeamOwnersResultQueryBuilder ExceptTeam() =>
            ExceptField("team");
        public RemoveTeamOwnersResultQueryBuilder WithErrors(RemoveTeamOwnersErrorQueryBuilder removeTeamOwnersErrorQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("errors", alias, removeTeamOwnersErrorQueryBuilder, new GraphQlDirective?[] { include, skip });
        public RemoveTeamOwnersResultQueryBuilder ExceptErrors() =>
            ExceptField("errors");
    }
}
