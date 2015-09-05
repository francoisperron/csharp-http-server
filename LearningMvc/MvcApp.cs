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
            RouteTable.Routes.MapRoute(
                "GET /", 
                "", 
                new { controller = "Home", action = "Get" },
                new { httpMethod = new HttpMethodConstraint("GET")});

            RouteTable.Routes.MapRoute(
                "POST /",
                "",
                new { controller = "Home", action = "Post" },
                new { httpMethod = new HttpMethodConstraint("POST") });
        }
    }
}