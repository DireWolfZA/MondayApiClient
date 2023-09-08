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
    }
}
