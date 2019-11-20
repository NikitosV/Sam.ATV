using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models
{
    public class BikeSearchResult : SearchResultItem
    {
        [IndexField("name")]
        public string BikeName { get; set; }

        [IndexField("type_engine")]
        public string TypeEngine { get; set; }

        [IndexField("max_speed")]
        public int MaxSpeed { get; set; }

        [IndexField("fuel")]
        public int Fuel { get; set; }

        [IndexField("description")]
        public string Description { get; set; }

        [IndexField("price")]
        public int Price { get; set; }
    }
}