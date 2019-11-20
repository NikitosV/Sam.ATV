using Sam.Foundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Feature.TripCard.Areas.TripCard.Models.ViewModels
{
    public interface ITripCardClass : ICmsEntity
    {
        Guid Id { get; set; }
        Glass.Mapper.Sc.Fields.Image Image { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int Price { get; set; }
    }
}
