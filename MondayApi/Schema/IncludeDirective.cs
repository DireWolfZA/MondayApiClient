namespace MondayApi.Schema {
    public class IncludeDirective : GraphQlDirective {
        public IncludeDirective(QueryBuilderParameter<bool> @if) : base("include") {
            AddArgument("if", @if);
        }
    }
}
