using Sam.ATV.Web.Areas.ATV.Logic.Services;
using Sam.ATV.Web.Areas.ATV.Models.ViewModels;
using Sam.Feature.BikeCard.Areas.BikeCard.Services;
using Sam.Feature.TripCard.Areas.TripCard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.ATV.Web.Areas.ATV.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;
        private readonly IBikeCardService _bikeCardService;
        private readonly ITripCardService _tripCardService;

        public SearchController(ISearchService searchService, IBikeCardService bikeCardService, ITripCardService tripCardService)
        {
            _searchService = searchService;
            _bikeCardService = bikeCardService;
            _tripCardService = tripCardService;
        }

        public ViewResult BikeSearch()
        {
            return View("~/Areas/ATV/Views/Search/BikeSearch.cshtml", new BikeSearchViewModel());
        }

        public ViewResult TripSearch()
        {
            return View("~/Areas/ATV/Views/Search/TripSearch.cshtml", new TripSearchViewModel());
        }

        public PartialViewResult SubmitBikeSearch(BikeSearchViewModel viewModel)
        {
            var resultsViewModel = new SearchResultsViewModel();

            var results = _searchService.SearchBikeCards(viewModel);
            resultsViewModel.CountBikes = _searchService.GetCountAllBikes(viewModel.SearchTerm);

            foreach (var result in results)
            {
                var bike = _bikeCardService.GetBikeCardContent(result.ItemId.ToString());

                resultsViewModel.Results.Add(new SearchResultViewModel()
                {
                    Id = result.ItemId.ToString(),
                    BikeName = result.BikeName,
                    TypeEngine = result.TypeEngine,
                    MaxSpeed = result.MaxSpeed,
                    ImgUrl = bike.Image.Src,
                    Fuel = result.Fuel,
                    Description = result.Description,
                    Price = result.Price
                });
            }

            return PartialView("~/Areas/ATV/Views/Search/_BikeSearchResult.cshtml", resultsViewModel);
        }

        public PartialViewResult SubmitTripSearch(TripSearchViewModel viewModel)
        {
            var resultsViewModel = new TripSearchResultsViewModel();

            var results = _searchService.SearchTripCards(viewModel);
            resultsViewModel.CountTrips = _searchService.GetCountAlTrips(viewModel.SearchTerm);

            foreach (var result in results)
            {
                var trip = _tripCardService.GetTripCardContent(result.ItemId.ToString());

                resultsViewModel.Results.Add(new TripSearchResultViewModel()
                {
                    Id = result.ItemId.ToString(),
                    Title = result.Title,
                    Description = result.Description,
                    ImgUrl = trip.Image.Src,
                    StartDate = result.StartDate,
                    EndDate = result.EndDate,
                    Price = result.Price
                });
            }

            return PartialView("~/Areas/ATV/Views/Search/_TripSearchResult.cshtml", resultsViewModel);
        }
    }
}

//public Provider ProviderIdByName(string name)
//{
//    using (var context = ContentSearchManager.GetIndex("sitecore_provider_index")
//        .CreateSearchContext())
//    {
//        var query = context.GetQueryable<SearchResultItem>().Where(x => x["profilename_t"].Contains(name));
//        var result = query.GetResults();

//        if (result != null && result.TotalSearchResults > 0)
//        {
//            var item = result.Hits.Where(i => i.Document != null).Select(i => i.Document).FirstOrDefault();
//            var service = new SitecoreService(Sitecore.Context.Database);

//            Provider resultItem = service.CreateType<Provider>(item.GetItem());
//            return resultItem;
//        }
//    }

//    return null;
//}
