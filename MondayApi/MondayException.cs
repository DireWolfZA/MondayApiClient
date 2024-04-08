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

        public MondayApiError MondayApiError { get; }
        public MondayException(MondayApiError mondayApiError) : base(
            mondayApiError.ErrorMessage ??
            mondayApiError.Errors?.FirstOrDefault() ??
            $"{mondayApiError.StatusCode}: {mondayApiError.ErrorCode}"
        ) {
            MondayApiError = mondayApiError;
        }

        public MondayException(string error) : base(error) { }

        public override string ToString() {
            if (ErrorData != null || MondayApiError != null) {
                var sb = new StringBuilder();
                string[] str = base.ToString().Split(new[] { Environment.NewLine }, 2, StringSplitOptions.None);
                sb.AppendLine(str[0]);

                var lineData = new List<string>();

                if (ErrorData?.Path?.Count > 0)
                    lineData.Add($"Path: {string.Join(".", ErrorData.Path.Select(p => p.ToString()))}");
                if (MondayApiError?.ErrorCode != null)
                    lineData.Add($"Error Code: {MondayApiError.ErrorCode}");
                if (MondayApiError?.StatusCode != null)
                    lineData.Add($"Status Code: {MondayApiError.StatusCode}");
                if (MondayApiError?.ErrorMessage != null)
                    lineData.Add($"Error Message: {MondayApiError.ErrorMessage}");
                if (MondayApiError?.Errors != null && MondayApiError.Errors.Length > 1)
                    lineData.Add($"Errors: {string.Join("; ", MondayApiError.Errors.Skip(1))}");

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
