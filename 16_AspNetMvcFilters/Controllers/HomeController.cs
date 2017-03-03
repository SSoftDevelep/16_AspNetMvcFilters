using _16_AspNetMvcFilters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_AspNetMvcFilters.Controllers
{
    [ActFilter, ResFilter, AuthFilter]
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }
    }
}