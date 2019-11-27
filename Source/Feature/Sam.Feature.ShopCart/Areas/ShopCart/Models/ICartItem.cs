using Sam.Foundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.ShopCart.Areas.ShopCart.Models
{
    public class ICartItem : ICmsEntity
    {
        Guid Id { get; set; }
        Glass.Mapper.Sc.Fields.Image Image { get; set; }
        string NameOfProduct { get; set; }
        int Price { get; set; }
    }
}