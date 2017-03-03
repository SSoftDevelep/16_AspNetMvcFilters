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

       [ExcFilter]
        public ActionResult Index2()
        {
            object sayi = 0;
            int deger = 100/(int)sayi;

            //throw new Exception("Kullanici yetkisiz giris yapti");
            return View();
        }

        [ExcFilter]
        public ActionResult Index3()
        {
            return View();
        }
    }
}