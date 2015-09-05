using System.Net;
using System.Web.Mvc;

namespace LearningMvc.Home
{
    public class HomeController : Controller
    {
        public ActionResult Get()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public ActionResult Post()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Created);
        }
    }
}