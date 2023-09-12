using System;
using System.Collections.Generic;
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
        public static GraphQlQueryParameter<IEnumerable<T>> GetParameterToMulti<T>(T value, bool isNullable = true) =>
            new GraphQlQueryParameter<IEnumerable<T>>(null, defaultValue: new T[] { value }, isNullable);
        public static GraphQlQueryParameter<T> GetParameterIfNotNull<T>(T value, bool isNullable = true) =>
            value == null ? null : new GraphQlQueryParameter<T>(null, defaultValue: value, isNullable);


        private static readonly Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings() {
            ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver() {
                NamingStrategy = new Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy()
            },
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
        };
        public static string SerializeColumnValues(Dictionary<string, IColumnValue> columnValues) =>
            Newtonsoft.Json.JsonConvert.SerializeObject(columnValues, settings);
        public static string SerializeColumnValue(IColumnValue columnValue) =>
            Newtonsoft.Json.JsonConvert.SerializeObject(columnValue, settings);
    }
}
