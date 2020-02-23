using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Unity;


using ILogger = Activity2Part3.Services.Utility.ILogger;


namespace WebApplication1.Controllers
{
    public class TestLoggingService2Controller : Controller
    {
        [Dependency]
        public ILogger logger { get; set; }

        // GET: TestLoggingService2
        public string Index()
        {
            this.logger.Info("Hello from the index method of the TestLogginService2Controller");

            return "Hello from the index method of the TestLogginService2Controller";
        }
    }
}