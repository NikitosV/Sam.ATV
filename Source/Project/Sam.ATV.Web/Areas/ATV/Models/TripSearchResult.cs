using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models
{
    public class TripSearchResult : SearchResultItem
    {

        public string Title { get; set; }

        [IndexField("description")]
        public string Description { get; set; }

        [IndexField("startdate")]
        public DateTime StartDate { get; set; }

        [IndexField("enddate")]
        public DateTime EndDate { get; set; }

        [IndexField("price")]
        public int Price { get; set; }
    }
}