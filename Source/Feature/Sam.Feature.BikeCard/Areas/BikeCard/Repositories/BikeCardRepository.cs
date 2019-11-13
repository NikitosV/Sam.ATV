using Glass.Mapper.Sc;
using Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using System;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Repositories
{
    public class BikeCardRepository : IBikeCardRepository
    {
        private readonly ISitecoreContext _sitecoreContext;

        public BikeCardRepository()
        {
            _sitecoreContext = new SitecoreContext();
        }

        public IBikeCardClass GetBikeCardContent(string contentGuid)
        {
            Assert.ArgumentNotNullOrEmpty(contentGuid, "contentGuid");
            return _sitecoreContext.GetItem<IBikeCardClass>(Guid.Parse(contentGuid));
        }
    }
}