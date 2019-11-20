using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.ViewModels
{
    public class SearchResultViewModel
    {
        public string ImgUrl { get; set; }

        public string Id { get; set; }

        public string BikeName { get; set; }

        public string TypeEngine { get; set; }

        public int MaxSpeed { get; set; }

        public int Fuel { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }
    }
}