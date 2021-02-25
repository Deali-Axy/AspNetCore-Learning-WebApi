using Newtonsoft.Json;

namespace Library.Api.Models {
    public class Link {
        public string Href { get; set; }
        public string Method { get; set; }

        [JsonProperty("rel")]
        public string Relation { get; set; }
    }
}