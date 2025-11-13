using System.Collections.Generic;

namespace MondayApi.Schema {
    public class ResponseForm {
        public int? ID { get; set; }
        public string? Token { get; set; }
        public bool? Active { get; set; }
        public string? Title { get; set; }
        public int? OwnerID { get; set; }
        public bool? BuiltWithAI { get; set; }
        public string? Description { get; set; }
        public ICollection<FormQuestion>? Questions { get; set; }
        public bool? IsAnonymous { get; set; }
        public string? Type { get; set; }
        public FormFeatures? Features { get; set; }
        public FormAppearance? Appearance { get; set; }
        public FormAccessibility? Accessibility { get; set; }
        public ICollection<FormTag>? Tags { get; set; }
    }
}
