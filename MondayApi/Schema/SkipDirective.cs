namespace MondayApi.Schema {
    public class SkipDirective : GraphQlDirective {
        public SkipDirective(QueryBuilderParameter<bool> @if) : base("skip") {
            AddArgument("if", @if);
        }
    }
}
