using System;

namespace Sam.Feature.TripCard.Areas.TripCard.Models.ViewModels
{
    public class TripCardClass : ITripCardClass
    {
        public Guid Id { get; set; }
        public Glass.Mapper.Sc.Fields.Image Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }

    }
}