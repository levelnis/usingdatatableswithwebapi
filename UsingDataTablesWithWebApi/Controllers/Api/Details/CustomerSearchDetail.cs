namespace Levelnis.Learning.UsingDataTablesWithWebApi.Controllers.Api.Details
{
    public class CustomerSearchDetail : SearchDetail
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string Telephone { get; set; }
    }
}