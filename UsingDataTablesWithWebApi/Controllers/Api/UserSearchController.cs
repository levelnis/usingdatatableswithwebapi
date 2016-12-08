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

    public class UserSearchController : SearchController
    {
        public IHttpActionResult Post(SearchRequest request)
        {
            var allUsers = JsonConvert.DeserializeObject<UserData>(UserData.DataSource);
            var response = WrapSearch(allUsers.Data, request);
            return Ok(response);
        }

        private static UserSearchResponse WrapSearch(ICollection<UserSearchDetail> details, SearchRequest request)
        {
            var results = ApiHelper.FilterUsers(details, request.Search.Value).ToList();
            var response = new UserSearchResponse
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
