﻿using _16_AspNetMvcFilters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_AspNetMvcFilters.Controllers
{
    public class HomeController : Controller
    {
       [ActFilter]
        public ActionResult Index()
        {
            return View();
        }

        [ActFilter]
        public ActionResult Index2()
        {
            return View();
        }

        [ActFilter]
        public ActionResult Index3()
        {
            return View();
        }
    }
}