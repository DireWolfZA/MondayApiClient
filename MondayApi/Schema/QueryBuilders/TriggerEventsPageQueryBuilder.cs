using System.Collections.Generic;

namespace MondayApi.Schema {
    public class TriggerEventsPageQueryBuilder : GraphQlQueryBuilder<TriggerEventsPageQueryBuilder> {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata = new[] {
            new GraphQlFieldMetadata { Name = "triggerEvents", IsComplex = true, QueryBuilderType = typeof(TriggerEventQueryBuilder) }
        };

        protected override string TypeName => "TriggerEventsPage";
        public override IReadOnlyList<GraphQlFieldMetadata> AllFields => AllFieldMetadata;

        public TriggerEventsPageQueryBuilder WithTriggerEvents(TriggerEventQueryBuilder triggerEventQueryBuilder, string? alias = null, IncludeDirective? include = null, SkipDirective? skip = null) =>
            WithObjectField("triggerEvents", alias, triggerEventQueryBuilder, new GraphQlDirective?[] { include, skip });
        public TriggerEventsPageQueryBuilder ExceptTriggerEvents() =>
            ExceptField("triggerEvents");
    }
}
