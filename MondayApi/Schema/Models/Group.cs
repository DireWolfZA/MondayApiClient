using System;

namespace MondayApi.Schema {
    public class Group {
        public bool? Archived { get; set; }
        public string Color { get; set; }
        public bool? Deleted { get; set; }
        public string ID { get; set; }
        public string Position { get; set; }
        public string Title { get; set; }
    }
}
