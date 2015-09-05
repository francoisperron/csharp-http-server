using System.Net;
using System.Web.Mvc;

namespace LearningMvc
{
    public class HomeController : Controller
    {
        public ActionResult Get()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}