using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels
{
    public class BikeCardViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TypeEngine { get; set; }
        public string MaxSpeed { get; set; }
        public string Fuel { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}