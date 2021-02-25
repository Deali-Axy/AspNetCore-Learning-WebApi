using System.Collections.Generic;
using Library.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers {
    [Route("api")]
    public class RootController : ControllerBase {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot() {
            var links = new List<Link> {
                new Link {Method = HttpMethods.Get, Href = "self", Relation = Url.Link(nameof(GetRoot), null)},
                new Link {Method = HttpMethods.Get, Href = "get authors", Relation = Url.Link(nameof(AuthorController.GetAuthorsAsync), null)},
                new Link {Method = HttpMethods.Post, Href = "create author", Relation = Url.Link(nameof(AuthorController.CreateAuthorAsync), null)}
            };
            return Ok(links);
        }
    }
}