using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AssignTeamOwnersResultQueryBuilder : GraphQlQueryBuilder<AssignTeamOwnersResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "team", IsComplex = true, QueryBuilderType = typeof(TeamQueryBuilder) },
            new GraphQlFieldMetadata { Name = "errors", IsComplex = true, QueryBuilderType = typeof(AssignTeamOwnersErrorQueryBuilder) }
        };

        protected override string TypeName => "AssignTeamOwnersResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AssignTeamOwnersResultQueryBuilder WithTeam(TeamQueryBuilder teamQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("team", alias, teamQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AssignTeamOwnersResultQueryBuilder ExceptTeam() =>
            ExceptField("team");
        public AssignTeamOwnersResultQueryBuilder WithErrors(AssignTeamOwnersErrorQueryBuilder assignTeamOwnersErrorQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("errors", alias, assignTeamOwnersErrorQueryBuilder, new GraphQlDirective?[] { include, skip });
        public AssignTeamOwnersResultQueryBuilder ExceptErrors() =>
            ExceptField("errors");
    }
}
