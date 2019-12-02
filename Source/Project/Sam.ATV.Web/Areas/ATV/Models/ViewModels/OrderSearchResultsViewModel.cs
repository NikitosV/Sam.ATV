using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.ViewModels
{
    public class OrderSearchResultsViewModel
    {
        public List<OrderSearchResultViewModel> Results = new List<OrderSearchResultViewModel>();
        public int CountOrders { get; set; }
    }
}