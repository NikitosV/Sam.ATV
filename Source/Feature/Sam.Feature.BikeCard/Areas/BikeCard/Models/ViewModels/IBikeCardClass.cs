using Sam.Foundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels
{
    public interface IBikeCardClass : ICmsEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string TypeEngine { get; set; }
        string MaxSpeed { get; set; }
        string Fuel { get; set; }
        string Description { get; set; }
        string Price { get; set; }
    }
}
