namespace Levelnis.Learning.UsingDataTablesWithWebApi.Controllers.Api
{
    using System.Web.Http;
    using Newtonsoft.Json;
    using Requests;
    using Responses;

public class CustomerSearchController : ApiController
{
    private const string CustomerData = @"
{
  ""Data"": [
    {
      ""CompanyName"": ""Microsoft"",
      ""Address"": ""1 Microsoft Way, London"",
      ""Postcode"": ""N1 1NN"",
      ""Telephone"": ""020 7100 1000""  
    },
    {
      ""CompanyName"": ""Nokia"",
      ""Address"": ""2 Nokia Way, London"",
      ""Postcode"": ""N2 2NN"",
      ""Telephone"": ""020 7200 2000""
    },
    {
      ""CompanyName"": ""Apple"",
      ""Address"": ""3 Apple Way, London"",
      ""Postcode"": ""N3 3NN"",
      ""Telephone"": ""020 7300 3000""
    },
    {
      ""CompanyName"": ""Google"",
      ""Address"": ""4 Google Way, London"",
      ""Postcode"": ""N4 4NN"",
      ""Telephone"": ""020 7400 4000""
    },
    {
      ""CompanyName"": ""Samsung"",
      ""Address"": ""5 Samsung Way, London"",
      ""Postcode"": ""N5 5NN"",
      ""Telephone"": ""020 7500 5000""
    }
  ] 
}";

    public IHttpActionResult Get([FromUri]SearchRequest request)
    {
        var allCustomers = JsonConvert.DeserializeObject<CustomerData>(CustomerData);
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
