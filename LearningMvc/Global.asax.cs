using System;
using System.Web;

namespace LearningMvc
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            new MvcApp().Start();
        }
    }
}