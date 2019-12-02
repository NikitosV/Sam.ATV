using Sam.Foundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.Order
{
    public interface IOrderClass : ICmsEntity
    {
        Guid Id { get; set; }
        string EmailName { get; set; }
        string BikeId { get; set; }
        string BikeName { get; set; }
        string Price { get; set; }
    }
}