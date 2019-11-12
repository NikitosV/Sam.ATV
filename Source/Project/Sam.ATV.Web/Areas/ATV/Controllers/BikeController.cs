using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.ATV.Web.Areas.ATV.Controllers
{
    public class BikeController : Controller
    {
        // GET: ATV/Bike
        public ActionResult Index()
        {
            return View();
        }
    }
}