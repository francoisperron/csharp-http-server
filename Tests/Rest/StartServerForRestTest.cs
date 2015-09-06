using NUnit.Framework;
using Tests.Helpers;

namespace Tests.Rest
{
    [SetUpFixture]
    public class StartServerForRestTest
    {
        private ServerDriver server;
        private static bool started;

        [SetUp]
        public void StartServer()
        {
            if (started) return;
            
            started = true;
            server = new IISExpress();
//            server = new WebApiServer();
            server.Start();
        }

        [TearDown]
        public void StopServer()
        {
            server.Stop();
        }
    }
}