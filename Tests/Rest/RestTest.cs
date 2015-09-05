using NUnit.Framework;
using Tests.Helpers;

namespace Tests.Rest
{
    [SetUpFixture]
    public class RestTest
    {
        private IISExpress server;
        private static bool started;

        [SetUp]
        public void StartServer()
        {
            if (started) return;
            
            started = true;
            StartIISExpress();
        }
        
        private void StartIISExpress()
        {
            server = IISExpress.Start(
                @"C:\Users\fperron\Documents\IISExpress\config\applicationhost.config",
                @"LearningMvc",
                @"Clr4IntegratedAppPool");
        }

        [TearDown]
        public void StopServer()
        {
            server.Stop();
        }
    }
}