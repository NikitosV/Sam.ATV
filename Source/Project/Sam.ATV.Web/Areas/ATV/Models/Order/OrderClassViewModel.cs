using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.Order
{
    public class OrderClassViewModel
    {
        public Guid Id { get; set; }
        public string EmailName { get; set; }
        public string BikeId { get; set; }
        public string BikeName { get; set; }
        public string Price { get; set; }
    }
}