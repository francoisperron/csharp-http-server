using System;
using NUnit.Framework;
using Tests.Helpers;

namespace Tests.Rest
{
    [SetUpFixture]
    public class StartServerForRestTest
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
            var iisExpressConfig = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + 
                                   @"\Documents\IISExpress\config\applicationhost.config";
            server = IISExpress.Start(
                iisExpressConfig,
                "LearningMvc",
                "Clr4IntegratedAppPool");
        }

        [TearDown]
        public void StopServer()
        {
            server.Stop();
        }
    }
}