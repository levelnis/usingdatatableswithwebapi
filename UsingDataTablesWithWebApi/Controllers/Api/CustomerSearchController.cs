namespace Levelnis.Learning.UsingDataTablesWithWebApi.Controllers.Api
{
    using System.Web.Http;
    using Newtonsoft.Json;
    using Requests;
    using Responses;

    public class CustomerSearchController : ApiController
    {
        public IHttpActionResult Post(SearchRequest request)
        {
            var allCustomers = JsonConvert.DeserializeObject<CustomerData>(CustomerData.DataSource);
            var response = new CustomerSearchResponse
            {
                Data = allCustomers.Data,
                Draw = request.Draw,
                RecordsFiltered = allCustomers.Data.Count,
                RecordsTotal = allCustomers.Data.Count
            };
            return Ok(response);
        }
    }
}