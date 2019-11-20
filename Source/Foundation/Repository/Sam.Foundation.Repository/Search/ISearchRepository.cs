using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sam.Foundation.Repository.Search
{
    public interface ISearchRepository
    {
        IEnumerable<T> Search<T>(Expression<Func<T, bool>> query) where T : SearchResultItem;
    }
}