using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.ViewModels
{
    public class SearchResultsViewModel
    {

        public List<SearchResultViewModel> Results = new List<SearchResultViewModel>();
        public int CountBikes { get; set; }
    }
}