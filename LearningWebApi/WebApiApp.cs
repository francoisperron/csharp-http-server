using System;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;

namespace LearningWebApi
{
    public class WebApiApp
    {
        public void Start(string baseUri)
        {
            WebApp.Start<WebApiApp>(baseUri);
        }

        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "Home",
                routeTemplate: "",
                defaults: new { controller = "Home" }
            );
            appBuilder.UseWebApi(config);
        }
    }

    public static class Program
    {
        static void Main()
        {
            var baseUri = "http://localhost:8008";
            new WebApiApp().Start(baseUri);

            Console.WriteLine("Server running at {0} - press Enter to quit. ", baseUri);
            Console.ReadLine();
        }
    }
}