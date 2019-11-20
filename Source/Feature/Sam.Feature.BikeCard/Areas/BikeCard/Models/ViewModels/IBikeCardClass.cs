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
        Glass.Mapper.Sc.Fields.Image Image { get; set; }
        string Name { get; set; }
        string TypeEngine { get; set; }
        int MaxSpeed { get; set; }
        int Fuel { get; set; }
        string Description { get; set; }
        int Price { get; set; }
    }
}
