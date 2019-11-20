using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels
{
    public class BikeCardClass : IBikeCardClass
    {
        public Guid Id { get; set; }
        public Glass.Mapper.Sc.Fields.Image Image { get; set; }
        public string Name { get; set; }
        public string TypeEngine { get; set; }
        public int MaxSpeed { get; set; }
        public int Fuel { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}