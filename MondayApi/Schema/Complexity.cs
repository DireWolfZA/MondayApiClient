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
    public class Complexity
    {
        public int? After { get; set; }
        public int? Before { get; set; }
        public int? Query { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("reset_in_x_seconds")]
        #endif
        public int? ResetInXSeconds { get; set; }
    }
}
