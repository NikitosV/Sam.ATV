using Sam.ATV.Web.Areas.ATV.Models;
using Sam.ATV.Web.Areas.ATV.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sam.ATV.Web.Areas.ATV.Logic.Services
{
    public interface ISearchService
    {
        int GetCountAllBikes(string searchText);
        int GetCountAlTrips(string searchText);
        IEnumerable<BikeSearchResult> SearchBikeCards(BikeSearchViewModel searchTerm);
        IEnumerable<TripSearchResult> SearchTripCards(TripSearchViewModel searchTerm);
    }
}
