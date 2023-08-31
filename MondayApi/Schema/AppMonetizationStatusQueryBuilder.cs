// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace MondayApi.Schema
{
    public class AppMonetizationStatusQueryBuilder : GraphQlQueryBuilder<AppMonetizationStatusQueryBuilder>
    {
        private static readonly GraphQlFieldMetadata[] AllFieldMetadata =
            new []
            {
                new GraphQlFieldMetadata { Name = "is_supported" }
            };

        protected override string TypeName { get { return "AppMonetizationStatus"; } } 

        public override IReadOnlyList<GraphQlFieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AppMonetizationStatusQueryBuilder WithIsSupported(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("is_supported", alias, new GraphQlDirective[] { include, skip });
        }

        public AppMonetizationStatusQueryBuilder ExceptIsSupported()
        {
            return ExceptField("is_supported");
        }
    }
}
