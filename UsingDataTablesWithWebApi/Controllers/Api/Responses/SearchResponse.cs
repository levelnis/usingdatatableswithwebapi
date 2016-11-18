namespace Levelnis.Learning.UsingDataTablesWithWebApi.Controllers.Api.Responses
{
    using System.Collections.Generic;
    using Details;

    public abstract class SearchResponse<T> where T : SearchDetail
    {
        public int Draw { get; set; }

        public int RecordsTotal { get; set; }

        public int RecordsFiltered { get; set; }

        public IList<T> Data { get; set; }
    }
}