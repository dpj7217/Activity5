using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication1.Controllers;
using System.Runtime.Caching;
using Newtonsoft.Json;
using MyLogger = Activity2Part3.Services.Utility.MyLogger;

namespace Activity2Part3.Controllers
{
    [CustomAction]
    public class LoginController : Controller
    {

        private static MyLogger logger = MyLogger.GetInstance().Value;


        public string GetUsers()
        {
            MemoryCache cache = MemoryCache.Default;
            List<Models.UserModel> Users = new List<Models.UserModel> {
                    new Models.UserModel("THEhansolo", "12Parsecs!"),
                    new Models.UserModel("Chewbacca", "FuzzBall567"),
                    new Models.UserModel("OlBenKenobi9721", "TheForceBeWithYou")
                };
            if (cache.Contains("Users"))
            {
                logger.Info("Users Already Exists");
            }
            else
            {
                DateTime time = new DateTime(60);

                cache.Add("Users", Users, time);

                logger.Info("System created cached List<UserModel>");
            }

            var json = JsonConvert.SerializeObject(Users);

            return json;

        }

        [HttpGet]
        [CustomAuthorization]
        public string Protected()
        {
            return "Test";
        }
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(Activity2Part3.Models.UserModel model)
        {
            try
            {
                logger.Info("Entering Login()");
                if (!ModelState.IsValid)
                    return View("Login");
                Services.Business.SecurityService service = new Services.Business.SecurityService();

                logger.Info("Parameters are: " + new JavaScriptSerializer().Serialize(model));
                bool authenticated = service.Authenticate(model);

                if (authenticated)
                {
                    logger.Info("Exiting Login() with pass");
                    return View("LoginPassed", model);
                }
                else
                {
                    logger.Info("Exiting Login() with Login failed");
                    return View("LoginFailed");
                }
            } catch (Exception e)
            {
                logger.Error("Login() exit with error: " + e.Message);
            }

            return View("LoginFailed");
        }
    }
}