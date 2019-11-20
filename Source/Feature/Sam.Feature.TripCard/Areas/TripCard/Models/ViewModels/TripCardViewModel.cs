using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.TripCard.Areas.TripCard.Models.ViewModels
{
    public class TripCardViewModel
    {
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }
    }
}