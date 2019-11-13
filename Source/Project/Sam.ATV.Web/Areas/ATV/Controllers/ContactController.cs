using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.ATV.Web.Areas.ATV.Controllers
{
    public class ContactController : Controller
    {
        // GET: ATV/Contact
        public ViewResult Index()
        {
            return View("~/Areas/ATV/Views/Contact/Index.cshtml");
        }
    }
}