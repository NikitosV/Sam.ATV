using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.ATV.Web.Areas.ATV.Models.ViewModels
{
    public class TripSearchResultsViewModel
    {
        public List<TripSearchResultViewModel> Results = new List<TripSearchResultViewModel>();
        public int CountTrips { get; set; }
    }
}