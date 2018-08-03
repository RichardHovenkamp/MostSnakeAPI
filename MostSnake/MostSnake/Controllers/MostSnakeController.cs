using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MostSnake.Controllers
{
    public class MostSnakeController : ApiController
    {
        public IHttpActionResult GetMostSnakeResult()
        {
            string result = "Some freaky result";
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetMostSnakeResultTest()
        {
            string result = "Some different result";
            return Ok(result);
        }
    }
}
