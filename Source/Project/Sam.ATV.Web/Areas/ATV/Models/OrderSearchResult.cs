using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models
{
    public class OrderSearchResult : SearchResultItem
    {
        [IndexField("bikeid")]
        public string BikeId { get; set; }
        [IndexField("bikename")]
        public string BikeName { get; set; }
        [IndexField("price")]
        public string Price { get; set; }
    }
}