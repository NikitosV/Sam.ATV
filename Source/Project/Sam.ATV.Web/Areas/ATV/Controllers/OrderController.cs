using Sam.ATV.Web.Areas.ATV.Logic.Services;
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
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void AddBikeToOrder(string BikeId)
        {
            using (new SecurityDisabler())
            {
                if(BikeId != null)
                {
                    _orderService.AddBikeAsOrder(BikeId);
                }
            }
        }
    }
}