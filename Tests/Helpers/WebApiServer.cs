
using LearningWebApi;

namespace Tests.Helpers
{
    public class WebApiServer : ServerDriver
    {
        private bool started;

        public void Start()
        {
            if (started) return;
            
            started = true;
            new WebApiApp().Start(Server.BaseUri);
        }

        public void Stop()
        {
        }
    }
}
