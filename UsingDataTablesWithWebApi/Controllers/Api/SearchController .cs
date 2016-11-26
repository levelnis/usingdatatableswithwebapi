namespace Levelnis.Learning.UsingDataTablesWithWebApi.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using Details;
    using Infrastructure;
    using Requests;

    public abstract class SearchController : ApiController
    {
        protected static IList<TDetail> PageResults<TDetail>(IEnumerable<TDetail> results, SearchRequest request) where TDetail : SearchDetail
        {
            var skip = request.Start;
            var pageSize = request.Length;
            var orderedResults = OrderResults(results, request);
            return pageSize > 0 ? orderedResults.Skip(skip).Take(pageSize).ToList() : orderedResults.ToList();
        }

        private static IEnumerable<TDetail> OrderResults<TDetail>(IEnumerable<TDetail> results, SearchRequest request) where TDetail : SearchDetail
        {
            if (request.Order == null) return results;
            var columnIndex = request.Order[0].Column;
            var sortDirection = request.Order[0].Dir;
            var columnName = request.Columns[columnIndex].Data.AsPropertyName();
            var prop = typeof(TDetail).GetProperty(columnName);
            return sortDirection == "asc" ? results.OrderBy(prop.GetValue) : results.OrderByDescending(prop.GetValue);
        }
    }
}