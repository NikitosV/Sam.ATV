using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.ShopCart.Areas.ShopCart.Models.ViewModels
{
    public class CartItemViewModel
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public string NameOfProuct { get; set; }
        public int Price { get; set; }
    }
}