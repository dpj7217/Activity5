using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ILogger = Activity2Part3.Services.Utility.ILogger;
using ITestService = WebApplication1.Services.Business.ITestService;

namespace WebApplication1.Controllers
{
    public class TestLoggingService3Controller : Controller
    {

        private readonly ILogger logger;
        private readonly ITestService service;
        
        public TestLoggingService3Controller(ILogger logger, ITestService service)
        {
            this.logger = logger;
            this.service = service;
            service.Initialize(logger);
        }

        // GET: TestLoggingService3
        public string Index()
        {
            this.logger.Info("Test message from the TestLoggingService3Controller");
            this.service.TestLogger();
            return "Hello From Index of the TestLoggingService3Controller";
        }
    }
}