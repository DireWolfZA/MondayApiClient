using System.Collections.Generic;

namespace MondayApi.Schema {
    public class AccountTriggerStatisticsQueryBuilder : GraphQlQueryBuilder<AccountTriggerStatisticsQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "id" },
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "failure" },
            new GraphQlFieldMetadata { Name = "total" }
        };

        protected override string TypeName => "AccountTriggerStatistics";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public AccountTriggerStatisticsQueryBuilder WithID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("id", alias, new GraphQlDirective?[] { include, skip });
        public AccountTriggerStatisticsQueryBuilder ExceptID() =>
            ExceptField("id");
        public AccountTriggerStatisticsQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public AccountTriggerStatisticsQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public AccountTriggerStatisticsQueryBuilder WithFailure(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("failure", alias, new GraphQlDirective?[] { include, skip });
        public AccountTriggerStatisticsQueryBuilder ExceptFailure() =>
            ExceptField("failure");
        public AccountTriggerStatisticsQueryBuilder WithTotal(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("total", alias, new GraphQlDirective?[] { include, skip });
        public AccountTriggerStatisticsQueryBuilder ExceptTotal() =>
            ExceptField("total");
    }
}
