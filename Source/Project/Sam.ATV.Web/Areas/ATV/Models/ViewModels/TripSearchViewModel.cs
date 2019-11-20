using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.ViewModels
{
    public class TripSearchViewModel
    {
        public string SearchTerm { get; set; }
        public int PageSize { get; set; }
        public int PageCurrent { get; set; }
    }
}