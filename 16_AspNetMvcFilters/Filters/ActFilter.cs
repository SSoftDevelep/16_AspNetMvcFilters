﻿using _16_AspNetMvcFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_AspNetMvcFilters.Filters
{
    public class ActFilter : FilterAttribute, IActionFilter // böylece attribute yazilabilir hale geldi.
    {
        DatabaseContext db = new DatabaseContext();
        //action calistiktan sonra
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            db.Logs.Add(new Log
            {
                KullaniciAdi = "system",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuted"

            });
            db.SaveChanges();
        }

        //action calismadan once
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            db.Logs.Add(new Log
            {
                KullaniciAdi = "system",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "OnActionExecuting"

            });
            db.SaveChanges();
        }
    }
}