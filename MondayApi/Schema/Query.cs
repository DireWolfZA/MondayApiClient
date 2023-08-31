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
    public class Query
    {
        public Account Account { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("app_subscription")]
        #endif
        public ICollection<AppSubscription> AppSubscription { get; set; }
        #if !GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
        [JsonProperty("apps_monetization_status")]
        #endif
        public AppMonetizationStatus AppsMonetizationStatus { get; set; }
        public ICollection<Asset> Assets { get; set; }
        public ICollection<Board> Boards { get; set; }
        public Complexity Complexity { get; set; }
        public ICollection<Document> Docs { get; set; }
        public ICollection<Folder> Folders { get; set; }
        public ICollection<Item> Items { get; set; }
        public User Me { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<Update> Updates { get; set; }
        public ICollection<User> Users { get; set; }
        public Version Version { get; set; }
        public ICollection<Version> Versions { get; set; }
        public ICollection<Webhook> Webhooks { get; set; }
        public ICollection<Workspace> Workspaces { get; set; }
    }
}
