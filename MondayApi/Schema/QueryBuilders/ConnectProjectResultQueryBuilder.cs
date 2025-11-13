using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ConnectProjectResultQueryBuilder : GraphQlQueryBuilder<ConnectProjectResultQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "success" },
            new GraphQlFieldMetadata { Name = "message" },
            new GraphQlFieldMetadata { Name = "portfolio_item_id" }
        };

        protected override string TypeName => "ConnectProjectResult";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public ConnectProjectResultQueryBuilder WithSuccess(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("success", alias, new GraphQlDirective?[] { include, skip });
        public ConnectProjectResultQueryBuilder ExceptSuccess() =>
            ExceptField("success");
        public ConnectProjectResultQueryBuilder WithMessage(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("message", alias, new GraphQlDirective?[] { include, skip });
        public ConnectProjectResultQueryBuilder ExceptMessage() =>
            ExceptField("message");
        public ConnectProjectResultQueryBuilder WithPortfolioItemID(string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithScalarField("portfolio_item_id", alias, new GraphQlDirective?[] { include, skip });
        public ConnectProjectResultQueryBuilder ExceptPortfolioItemID() =>
            ExceptField("portfolio_item_id");
    }
}
