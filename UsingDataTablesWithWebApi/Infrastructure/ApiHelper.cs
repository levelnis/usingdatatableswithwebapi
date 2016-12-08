namespace Levelnis.Learning.UsingDataTablesWithWebApi.Infrastructure
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.WebPages;
    using Controllers.Api.Details;

    public static class ApiHelper
    {
        public static IEnumerable<CustomerSearchDetail> FilterCustomers(IEnumerable<CustomerSearchDetail> details, string searchText)
        {
            if (searchText.IsEmpty())
            {
                return details;
            }

            var results = details.Where(x => x.CompanyName.ContainsIgnoringCase(searchText)
                || x.Address.ContainsIgnoringCase(searchText)
                || x.Postcode.ContainsIgnoringCase(searchText)
                || x.Telephone.ContainsIgnoringCase(searchText)
                );

            return results;
        }

        public static IEnumerable<UserSearchDetail> FilterUsers(IEnumerable<UserSearchDetail> details, string searchText)
        {
            if (searchText.IsEmpty())
            {
                return details;
            }

            var results = details.Where(x => x.CompanyName.ContainsIgnoringCase(searchText)
                || x.FirstName.ContainsIgnoringCase(searchText)
                || x.LastName.ContainsIgnoringCase(searchText)
                || x.Email.ContainsIgnoringCase(searchText)
                || x.JobTitle.ContainsIgnoringCase(searchText)
                );

            return results;
        }
    }
}