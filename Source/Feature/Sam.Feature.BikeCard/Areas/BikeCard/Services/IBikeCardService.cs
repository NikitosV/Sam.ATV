using Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Services
{
    public interface IBikeCardService
    {
        IBikeCardClass GetBikeCardContent(string contentGuid);
    }
}
