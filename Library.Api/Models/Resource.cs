using System.Collections.Generic;
using Newtonsoft.Json;

namespace Library.Api.Models {
    public class Resource {
        [JsonProperty("_links", Order = 100)]
        public List<Link> Links { get; } = new List<Link>();
    }
}