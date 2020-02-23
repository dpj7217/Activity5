using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using MyLogger = Activity2Part3.Services.Utility.MyLogger;

namespace WebApplication1.Controllers
{
    public class CustomActionAttribute: FilterAttribute, IActionFilter
    {
        private static MyLogger logger = MyLogger.GetInstance().Value;

        public void OnActionExecuted(ActionExecutedContext context)
        {

            string Action = context.ActionDescriptor.ActionName;
            string Controller = context.ActionDescriptor.ControllerDescriptor.ControllerName;
            string info = String.Format("Controller: {0}; Action: {1}", Action, Controller);
            logger.Info(info);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string Action = context.ActionDescriptor.ActionName;
            string Controller = context.ActionDescriptor.ControllerDescriptor.ControllerName;
            string info = String.Format("Controller: {0}; Action: {1}", Action, Controller);
            logger.Info(info);
        }
    }
}