using _16_AspNetMvcFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_AspNetMvcFilters.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SignIn()
        {
            return View(new SiteUser());
        }

        [HttpPost]
        public ActionResult SignIn(SiteUser model)
        {
            DatabaseContext db = new DatabaseContext();
            SiteUser user = db.SiteUsers.FirstOrDefault(x => 
            x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre);  //bulursan döndür bulamazsan default (null) döndür.

            if (user==null)
            {
                ModelState.AddModelError("", "Hatalı kullanıcı adı yada sifre");
                return View(model);
            }

            else
            {
                Session["login"] = user;
                return RedirectToAction("Index", "Home");
            }
            
        }

        public ActionResult Error()
        {
            if (TempData["error"]==null)
            
                return RedirectToAction("Index", "Home");
            
            Exception model = TempData["error"] as Exception;
            return View(model);
        }
    }
}