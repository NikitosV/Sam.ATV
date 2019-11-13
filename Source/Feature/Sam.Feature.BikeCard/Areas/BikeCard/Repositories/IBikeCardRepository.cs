using Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels;
using Sitecore.Data.Items;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Repositories
{
    public interface IBikeCardRepository
    {
        IBikeCardClass GetBikeCardContent(string contentGuid);
    }
}
