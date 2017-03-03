using _16_AspNetMvcFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_AspNetMvcFilters.Filters
{
    public class ExcFilter : FilterAttribute, IExceptionFilter
    {
        DatabaseContext db = new DatabaseContext();
        public void OnException(ExceptionContext filterContext)
        {
            string username = string.Empty;
            if (filterContext.HttpContext.Session["login"]!=null)
            {
                username = (filterContext.HttpContext.Session["login"] as SiteUser).KullaniciAdi; //session bos degilse sessiondaki kullanici adini username e atadik.
            }
            db.Logs.Add(new Log
            {
                KullaniciAdi = username,
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),

                Tarih = DateTime.Now,
                Bilgi = "Error : " +filterContext.Exception.Message

            });
            db.SaveChanges();


            filterContext.ExceptionHandled = true; //hatayi bizim yonetmemiz icin.
            filterContext.Controller.TempData["error"] = filterContext.Exception;
            filterContext.Result = new RedirectResult("/Login/Error");

        }
    }
}