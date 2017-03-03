using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_AspNetMvcFilters.Filters
{
    public class AuthFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext) //yetki kontrolu icin calisicak metod.
        {
            if(filterContext.HttpContext.Session["login"]==null)
            {
                filterContext.Result = new RedirectResult("/Login/SignIn");
            }
        }
    }
}