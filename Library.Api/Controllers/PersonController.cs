using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers.V1 {
    [Route("api/person")]
    [ApiVersion("1.0")]
    public class PersonController : ControllerBase {
        [HttpGet]
        public ActionResult<string> Get() => "Result from v1";
    }
}

namespace Library.API.Controllers.V2 {
    [Route("api/person")]
    [ApiVersion("2.0")]
    public class PersonController : ControllerBase {
        [HttpGet]
        public ActionResult<string> Get() => "Result from v2";
    }
}