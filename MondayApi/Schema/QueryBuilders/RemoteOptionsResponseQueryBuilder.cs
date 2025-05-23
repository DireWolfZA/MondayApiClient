using System.Collections.Generic;

namespace MondayApi.Schema {
    public class RemoteOptionsResponseQueryBuilder : GraphQlQueryBuilder<RemoteOptionsResponseQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "options", IsComplex = true, QueryBuilderType = typeof(OptionQueryBuilder) },
            new GraphQlFieldMetadata { Name = "isPaginated" },
            new GraphQlFieldMetadata { Name = "isLastPage" },
            new GraphQlFieldMetadata { Name = "nextPageRequestData", IsComplex = true, QueryBuilderType = typeof(NextPageRequestDataQueryBuilder) },
            new GraphQlFieldMetadata { Name = "disclaimer" }
        };

        protected override string TypeName => "RemoteOptionsResponse";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public RemoteOptionsResponseQueryBuilder WithOptions(OptionQueryBuilder optionQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("options", alias, optionQueryBuilder, new GraphQlDirective?[] { include, skip });
        public RemoteOptionsResponseQueryBuilder ExceptOptions() =>
            ExceptField("options");
        public RemoteOptionsResponseQueryBuilder WithIsPaginated(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isPaginated", alias, new GraphQlDirective?[] { include, skip });
        public RemoteOptionsResponseQueryBuilder ExceptIsPaginated() =>
            ExceptField("isPaginated");
        public RemoteOptionsResponseQueryBuilder WithIsLastPage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("isLastPage", alias, new GraphQlDirective?[] { include, skip });
        public RemoteOptionsResponseQueryBuilder ExceptIsLastPage() =>
            ExceptField("isLastPage");
        public RemoteOptionsResponseQueryBuilder WithNextPageRequestData(NextPageRequestDataQueryBuilder nextPageRequestDataQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("nextPageRequestData", alias, nextPageRequestDataQueryBuilder, new GraphQlDirective?[] { include, skip });
        public RemoteOptionsResponseQueryBuilder ExceptNextPageRequestData() =>
            ExceptField("nextPageRequestData");
        public RemoteOptionsResponseQueryBuilder WithDisclaimer(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("disclaimer", alias, new GraphQlDirective?[] { include, skip });
        public RemoteOptionsResponseQueryBuilder ExceptDisclaimer() =>
            ExceptField("disclaimer");
    }
}
