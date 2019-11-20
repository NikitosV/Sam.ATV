using Sam.Feature.TripCard.Areas.TripCard.Models.ViewModels;
using Sam.Foundation.Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.TripCard.Areas.TripCard.Services
{
    public class TripCardService : ITripCardService
    {
        private readonly IContentRepository _repository;

        public TripCardService(IContentRepository repository)
        {
            _repository = repository; //new SitecoreContentRepository();
        }

        public ITripCardClass GetTripCardContent(string contentGuid)
        {
            return _repository.GetContentItem<ITripCardClass>(contentGuid);
        }
    }
}