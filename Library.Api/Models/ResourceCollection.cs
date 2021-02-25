using System.Collections.Generic;

namespace Library.Api.Models {
    public class ResourceCollection<T> : Resource where T : Resource {
        public List<T> Items { get; set; }
    }
}