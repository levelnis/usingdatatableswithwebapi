namespace Levelnis.Learning.UsingDataTablesWithWebApi.Controllers.Api
{
    using System.Collections.Generic;
    using Details;

    public class UserData
    {
        public const string DataSource = @"
{
  ""Data"": [
    {
      ""CompanyName"": ""Microsoft"",
      ""FirstName"": ""Dave"",
      ""LastName"": ""Smith"",
      ""Email"": ""dave.smith@microsoft.com"",
      ""JobTitle"": ""Project Manager""
    },
    {
      ""CompanyName"": ""Nokia"",
      ""FirstName"": ""John"",
      ""LastName"": ""Smith"",
      ""Email"": ""john.smith@nokia.com"",
      ""JobTitle"": ""Project Manager""
    },
    {
      ""CompanyName"": ""Apple"",
      ""FirstName"": ""Paul"",
      ""LastName"": ""Jones"",
      ""Email"": ""paul.jones@apple.com"",
      ""JobTitle"": ""Product Manager""
    },
    {
      ""CompanyName"": ""Google"",
      ""FirstName"": ""Leslie"",
      ""LastName"": ""Richards"",
      ""Email"": ""leslie.richards@google.com"",
      ""JobTitle"": ""Product Director""
    },
    {
      ""CompanyName"": ""Samsung"",
      ""FirstName"": ""Michelle"",
      ""LastName"": ""Davis"",
      ""Email"": ""michelle.davis@samsung.com"",
      ""JobTitle"": ""Programme Manager""
    }
  ] 
}";

        public IList<UserSearchDetail> Data { get; set; }
    }
}