using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

using ILogger = Activity2Part3.Services.Utility.ILogger;

namespace WebApplication1.Services.Business
{
    public class TestService : ITestService
    {
        private ILogger logger;
       
        [InjectionMethod]
        public void Initialize(ILogger logger)
        {
            this.logger = logger;
        }

        public void TestLogger()
        {
            logger.Info("Test Logging in TestService.TestLogger() invoked.");
        }


    }
}