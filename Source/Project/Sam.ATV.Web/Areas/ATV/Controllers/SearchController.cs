using Sam.ATV.Web.Areas.ATV.Logic.Services;
using Sam.ATV.Web.Areas.ATV.Models.Order.ViewModels;
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
        private readonly IOrderService _orderService;

        public SearchController(ISearchService searchService, IBikeCardService bikeCardService, ITripCardService tripCardService, IOrderService orderService)
        {
            _searchService = searchService;
            _bikeCardService = bikeCardService;
            _tripCardService = tripCardService;
            _tripCardService = tripCardService;
            _orderService = orderService;
        }

        public ViewResult BikeSearch()
        {
            return View("~/Areas/ATV/Views/Search/BikeSearch.cshtml", new BikeSearchViewModel());
        }

        public ViewResult TripSearch()
        {
            return View("~/Areas/ATV/Views/Search/TripSearch.cshtml", new TripSearchViewModel());
        }

        public ViewResult OrderSearch()
        {
            return View("~/Areas/ATV/Views/Search/OrderSearch.cshtml", new OrderViewModel());
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

        public PartialViewResult SubmitOrderSearch(OrderViewModel viewModel)
        {

            var email = User.Identity.Name;
            var resultsViewModel = new OrderSearchResultsViewModel();

            var results = _searchService.GetOrdersByEmail(email, viewModel);
            resultsViewModel.CountOrders = _searchService.GetCountAlOrders(viewModel.SearchTerm);

            foreach (var result in results)
            {
                var trip = _orderService.GetOrderCardContent(result.ItemId.ToString());

                resultsViewModel.Results.Add(new OrderSearchResultViewModel()
                {
                    OrderId = result.ItemId.ToString(),
                    BikeId = result.BikeId,
                    BikeName = result.BikeName,
                    Price = result.Price
                });
            }

            return PartialView("~/Areas/ATV/Views/Search/_OrderSearchResult.cshtml", resultsViewModel);
        }
    }
}
