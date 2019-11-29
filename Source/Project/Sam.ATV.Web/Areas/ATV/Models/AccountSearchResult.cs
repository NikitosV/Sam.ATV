using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models
{
    public class AccountSearchResult : SearchResultItem
    {
        [IndexField("emailfield")]
        public string EmailField { get; set; }
    }
}