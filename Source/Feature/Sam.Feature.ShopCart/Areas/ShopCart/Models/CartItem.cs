using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.ShopCart.Areas.ShopCart.Models
{
    public class CartItem : ICartItem
    {
        public Guid Id { get; set; }
        public Glass.Mapper.Sc.Fields.Image Image { get; set; }
        public string NameOfProduct { get; set; }
        public int Price { get; set; }
    }
}