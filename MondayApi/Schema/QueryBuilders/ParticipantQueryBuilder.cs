using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ParticipantQueryBuilder : GraphQlQueryBuilder<ParticipantQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "email" }
        };

        protected override string TypeName => "Participant";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ParticipantQueryBuilder WithEmail(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("email", alias, new GraphQlDirective?[] { include, skip });
        public ParticipantQueryBuilder ExceptEmail() =>
            ExceptField("email");
    }
}
