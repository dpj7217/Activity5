﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [HttpGet]
        [CustomAuthorization]
        public string Index()
        {
            return "";
        }
    }
}