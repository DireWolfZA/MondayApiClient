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
    public class CreateDocInput : IGraphQlInputObject
    {
        private InputPropertyInfo _board;
        private InputPropertyInfo _workspace;

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<CreateDocBoardInput>))]
        #endif
        public QueryBuilderParameter<CreateDocBoardInput> Board
        {
            get { return (QueryBuilderParameter<CreateDocBoardInput>)_board.Value; }
            set { _board = new InputPropertyInfo { Name = "board", Value = value }; }
        }

        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonConverter(typeof(QueryBuilderParameterConverter<CreateDocWorkspaceInput>))]
        #endif
        public QueryBuilderParameter<CreateDocWorkspaceInput> Workspace
        {
            get { return (QueryBuilderParameter<CreateDocWorkspaceInput>)_workspace.Value; }
            set { _workspace = new InputPropertyInfo { Name = "workspace", Value = value }; }
        }

        IEnumerable<InputPropertyInfo> IGraphQlInputObject.GetPropertyValues()
        {
            if (_board.Name != null) yield return _board;
            if (_workspace.Name != null) yield return _workspace;
        }
    }
}
