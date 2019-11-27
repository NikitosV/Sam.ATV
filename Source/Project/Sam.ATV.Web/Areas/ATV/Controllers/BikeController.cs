using Sam.ATV.Web.Areas.ATV.Models.Account;
using Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels;
using Sitecore.SecurityModel;
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
        public ViewResult Bike()
        {
            return View("~/Areas/ATV/Views/Bike/Bike.cshtml");
        }
    }
}