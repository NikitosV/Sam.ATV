using System.Collections.Generic;
using System.Linq;
using Sam.ATV.Web.Areas.ATV.Models;
using Sam.ATV.Web.Areas.ATV.Models.ViewModels;
using Sam.Foundation.Repository.Search;

namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public class SearchService : ISearchService
    {
        private readonly ISearchRepository _searchRepository;

        public SearchService(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
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
    }
}