using Sam.Feature.TripCard.Areas.TripCard.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Feature.TripCard.Areas.TripCard.Services
{
    public interface ITripCardService
    {
        ITripCardClass GetTripCardContent(string contentGuid);
    }
}
