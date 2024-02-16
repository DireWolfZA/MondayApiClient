using System;
using System.Collections.Generic;
using System.Linq;
using MondayApi.Schema;

namespace MondayApi {
    internal class Utils {
        // Copied from old version of RestSharp.Validation
        /// <summary>Require a parameter to not be null</summary>
        /// <param name="argumentName">Name of the parameter</param>
        /// <param name="argumentValue">Value of the parameter</param>
        public static void RequireArgument(string argumentName, object argumentValue) {
            if (argumentValue == null)
                throw new ArgumentNullException(argumentName);
        }

        public static GraphQlQueryParameter<T> GetParameter<T>(T value, bool isNullable = true) =>
            new GraphQlQueryParameter<T>(null, defaultValue: value, isNullable);
        public static GraphQlQueryParameter<T> GetParameterIfNotNull<T>(T value, bool isNullable = true) =>
            value == null ? null : new GraphQlQueryParameter<T>(null, defaultValue: value, isNullable);

        public static GraphQlQueryParameter<IEnumerable<T>> GetParameterToMulti<T>(T value, bool isNullable = true) =>
            new GraphQlQueryParameter<IEnumerable<T>>(null, defaultValue: new T[] { value }, isNullable);
        public static GraphQlQueryParameter<IEnumerable<T?>> GetParameterWithNameToMulti<T>(T value) where T : struct, Enum =>
            new GraphQlQueryParameter<IEnumerable<T?>>(null, typeof(T).Name, new T?[] { value });


        private static readonly Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings() {
            ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver() {
                NamingStrategy = new Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy()
            },
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
        };

        private static object convertColumn(IColumnValue column) {
            column.ID = null;
            switch (column) {
                case TextValue tv:
                    return tv.Text ?? tv.Value;
                case NumbersValue nv:
                    return nv.Number ?? nv.Text ?? nv.Value;
                case PeopleValue pv:
                    return new PeopleValueForUpdate() {
                        PersonsAndTeams = pv.PersonsAndTeams?.Select(pe => new PeopleEntityForUpdate() { ID = pe.ID, Kind = pe.Kind.ToString().ToLowerInvariant() }).ToList()
                    };
                case CheckboxValue cv:
                    return cv.Checked.HasValue && cv.Checked.Value
                        ? new CheckboxValueForUpdate() { Checked = "true" }
                        : null;
                default:
                    return column;
            }
        }

        public static string SerializeColumnValues(IEnumerable<IColumnValue> columnValues) {
            if (columnValues == null)
                return null;
            var dict = columnValues.ToDictionary<IColumnValue, string, object>(column => column.ID, convertColumn);
            return Newtonsoft.Json.JsonConvert.SerializeObject(dict, settings);
        }
        public static string SerializeColumnValue(IColumnValue columnValue) =>
            Newtonsoft.Json.JsonConvert.SerializeObject(convertColumn(columnValue), settings);

        internal static bool TryDeserializeMondayApiError(string response, out MondayApiError mondayApiError) {
            try {
                mondayApiError = Newtonsoft.Json.JsonConvert.DeserializeObject<MondayApiError>(response, settings);
                return true;
            } catch (Newtonsoft.Json.JsonReaderException) {
                mondayApiError = null;
                return false;
            }
        }
    }
}
