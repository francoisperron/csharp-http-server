using System.Web.Http;

namespace LearningWebApi.Home
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok();
        }

        public IHttpActionResult Post()
        {
            return Created(Request.RequestUri, "");
        }
    }
}
