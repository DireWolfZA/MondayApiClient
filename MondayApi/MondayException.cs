using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphQL;

namespace MondayApi {
    public class MondayException : Exception {
        public GraphQLError ErrorData { get; }
        public MondayException(GraphQLError error) : base(error.Message) {
            ErrorData = error;
        }
        public MondayException(string error) : base(error) { }

        public override string ToString() {
            if (ErrorData != null) {
                var sb = new StringBuilder();
                string[] str = base.ToString().Split(new[] { Environment.NewLine }, 2, StringSplitOptions.None);
                sb.AppendLine(str[0]);

                var lineData = new List<string>();

                if (ErrorData.Path?.Count > 0)
                    lineData.Add($"Path: {string.Join(".", ErrorData.Path.Select(p => p.ToString()))}");

                if (lineData.Count > 0)
                    sb.AppendLine(string.Join(", ", lineData));

                if (str.Length > 1)
                    sb.Append(str[1]);
                else // remove trailing newline if we don't append base last line of text
                    sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            } else {
                return base.ToString();
            }
        }

        public static AggregateException FromErrors(IEnumerable<GraphQLError> errors) =>
            new AggregateException(errors.Select(e => new MondayException(e)));
    }
}
