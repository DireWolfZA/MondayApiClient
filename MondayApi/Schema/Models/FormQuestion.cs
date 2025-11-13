using System.Collections.Generic;

namespace MondayApi.Schema {
    public class FormQuestion {
        public string? ID { get; set; }
        public FormQuestionType? Type { get; set; }
        public bool? Visible { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool? Required { get; set; }
        public FormQuestionSettings? Settings { get; set; }
        public ICollection<FormQuestionOption>? Options { get; set; }
        public object? ShowIfRules { get; set; }
    }
}
