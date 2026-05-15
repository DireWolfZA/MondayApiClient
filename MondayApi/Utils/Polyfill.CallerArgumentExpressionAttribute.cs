#if NETSTANDARD2_0
#pragma warning disable

using System.Diagnostics;

namespace System.Runtime.CompilerServices {
    [DebuggerNonUserCode]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    internal sealed class CallerArgumentExpressionAttribute : Attribute {
        public CallerArgumentExpressionAttribute(string parameterName) {
            ParameterName = parameterName;
        }
        public string ParameterName { get; }
    }
}

#pragma warning restore
#endif
