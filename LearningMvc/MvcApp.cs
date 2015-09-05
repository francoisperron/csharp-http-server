using System.Web.Mvc;
using System.Web.Routing;

namespace LearningMvc
{
    public class MvcApp
    {
        public void Start()
        {
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            AreaRegistration.RegisterAllAreas();
            RouteTable.Routes.MapRoute("Home", "", new { controller = "Home", action = "Get" });
        }
    }
}