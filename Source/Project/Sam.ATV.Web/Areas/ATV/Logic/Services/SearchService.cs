using System.Collections.Generic;
using System.Linq;
using Sam.ATV.Web.Areas.ATV.Models;
using Sam.ATV.Web.Areas.ATV.Models.Account;
using Sam.ATV.Web.Areas.ATV.Models.Order.ViewModels;
using Sam.ATV.Web.Areas.ATV.Models.ViewModels;
using Sam.Foundation.Repository.Content;
using Sam.Foundation.Repository.Search;
using Sitecore.Data;

namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public class SearchService : ISearchService
    {
        private readonly ISearchRepository _searchRepository;
        private readonly IContentRepository _contentRepository;

        public static Database Master = Sitecore.Data.Database.GetDatabase("master");
        public static Database WebSitecore = Sitecore.Data.Database.GetDatabase("web");

        public SearchService(ISearchRepository searchRepository, IContentRepository contentRepository)
        {
            _searchRepository = searchRepository;
            _contentRepository = contentRepository;
        }

        public int GetCountAllBikes(string searchText)
        {
            int count = 0;

            if (searchText != null)
            {
                count = _searchRepository.Search<BikeSearchResult>(
                   q => q.BikeName.Contains(searchText) &&
                   q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Bikes/")).Count();
            }
            else
            {
                count = _searchRepository.Search<BikeSearchResult>(
                   q => q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Bikes/")).Count();
            }

            return count;
        }

        public int GetCountAlTrips(string searchText)
        {
            int count = 0;

            if (searchText != null)
            {
                count = _searchRepository.Search<TripSearchResult>(
                   q => q.Title.Contains(searchText) &&
                   q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Trips/")).Count();
            }
            else
            {
                count = _searchRepository.Search<TripSearchResult>(
                   q => q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Trips/")).Count();
            }

            return count;
        }

        public IEnumerable<BikeSearchResult> SearchBikeCards(BikeSearchViewModel searchTerm)
        {

            //зделать так, если папка, пропускает
            IEnumerable<BikeSearchResult> bikes = null;

            if (searchTerm.SearchTerm == null)
            {
                bikes = _searchRepository.Search<BikeSearchResult>(
                   q => q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Bikes/"))
                   .Skip((searchTerm.PageCurrent - 1) * searchTerm.PageSize)
                   .Take(searchTerm.PageSize);
            }
            else
            {
                bikes = _searchRepository.Search<BikeSearchResult>(
                    q => q.BikeName.Contains(searchTerm.SearchTerm) &&
                    q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Bikes/"))
                    .Skip((searchTerm.PageCurrent - 1) * searchTerm.PageSize)
                    .Take(searchTerm.PageSize);
            }

            return bikes;//return _searchRepository.Search<BikeSearchResult>(q => q.BikeName.Contains(searchTerm) && q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Bikes"));
        }

        public IEnumerable<TripSearchResult> SearchTripCards(TripSearchViewModel searchTerm)
        {
            IEnumerable<TripSearchResult> trips = null;

            if (searchTerm.SearchTerm == null)
            {
                trips = _searchRepository.Search<TripSearchResult>(
                   q => q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Trips/"))
                   .Skip((searchTerm.PageCurrent - 1) * searchTerm.PageSize)
                   .Take(searchTerm.PageSize);
            }
            else
            {
                trips = _searchRepository.Search<TripSearchResult>(
                    q => q.Title.Contains(searchTerm.SearchTerm) &&
                    q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Trips/"))
                    .Skip((searchTerm.PageCurrent - 1) * searchTerm.PageSize)
                    .Take(searchTerm.PageSize);
            }

            return trips;
        }

        public AccountProfileViewModel GetByEmail(string email)
        {
            var accountItem = _searchRepository.Search<AccountSearchResult>(
                q => q.EmailField.Equals(email) &&
                q.Path.StartsWith("/sitecore/content/Sam/ATV/Users Data/"))
                .FirstOrDefault();

            var item = Master.GetItem(accountItem.ItemId.ToString());

            var account = _contentRepository.GetContentItem<AccountProfile>(accountItem.ItemId.ToString());

            return new AccountProfileViewModel()
            {
                Id = account.Id,
                Email = item.Fields["EmailField"].Value,
                NameUVM = account.NameUser,
                PhoneUVM = account.PhoneUser,
                SurnameUVM = account.SurnameUser
            };
        }

        public IEnumerable<OrderSearchResult> GetOrdersByEmail(string email, OrderViewModel searchTerm)
        {
            IEnumerable<OrderSearchResult> orders = null;

            if (searchTerm.SearchTerm == null)
            {
                orders = _searchRepository.Search<OrderSearchResult>(
                   q => q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Trips/"))
                   .Skip((searchTerm.PageCurrent - 1) * searchTerm.PageSize)
                   .Take(searchTerm.PageSize);
            }
            else
            {
                orders = _searchRepository.Search<OrderSearchResult>(
                    q => q.Title.Contains(searchTerm.SearchTerm) &&
                    q.Path.StartsWith("/sitecore/content/Sam/ATV/Data/Trips/"))
                    .Skip((searchTerm.PageCurrent - 1) * searchTerm.PageSize)
                    .Take(searchTerm.PageSize);
            }

            return orders;
        }
    }
}