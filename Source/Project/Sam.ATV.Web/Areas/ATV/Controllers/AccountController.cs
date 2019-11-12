
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.ATV.Web.Areas.ATV.Controllers
{
    public class AccountController : Controller
    {
        // GET: ATV/Account
        public ViewResult Login()
        {
            return View("~/Areas/ATV/Views/Account/Login.cshtml");
        }

        public ViewResult Register()
        {
            return View("~/Areas/ATV/Views/Account/Register.cshtml");
        }
    }
}