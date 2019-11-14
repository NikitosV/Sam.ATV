using Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels;
using Sam.Feature.BikeCard.Areas.BikeCard.Repositories;
using Sam.Foundation.Repository.Content;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Services
{
    public class BikeCardService : IBikeCardService
    {
        private readonly IContentRepository _repository;

        public BikeCardService(IContentRepository repository)
        {
            _repository = repository; //new SitecoreContentRepository();
        }

        public IBikeCardClass GetBikeCardContent(string contentGuid)
        {
            return _repository.GetContentItem<IBikeCardClass>(contentGuid);
        }
    }
}