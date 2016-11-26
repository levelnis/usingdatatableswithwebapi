namespace Levelnis.Learning.UsingDataTablesWithWebApi.Controllers.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using Details;
    using Infrastructure;
    using Newtonsoft.Json;
    using Requests;
    using Responses;

    public class CustomerSearchController : SearchController
    {
        public IHttpActionResult Post(SearchRequest request)
        {
            var allCustomers = JsonConvert.DeserializeObject<CustomerData>(CustomerData.DataSource);
            var response = WrapSearch(allCustomers.Data, request);
            return Ok(response);
        }

        private static CustomerSearchResponse WrapSearch(ICollection<CustomerSearchDetail> details, SearchRequest request)
        {
            var results = ApiHelper.FilterCustomers(details, request.Search.Value).ToList();
            var response = new CustomerSearchResponse
            {
                Data = PageResults(results, request),
                Draw = request.Draw,
                RecordsFiltered = results.Count,
                RecordsTotal = details.Count
            };
            return response;
        }
    }
}