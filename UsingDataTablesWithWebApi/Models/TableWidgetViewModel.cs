namespace Levelnis.Learning.UsingDataTablesWithWebApi.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;
    using Infrastructure;

    public class TableWidgetViewModel
    {
        public IList<string> ClientColumns { get; set; }
        public IList<string> Columns { get; set; }
        public string TableId { get; set; }
        public string WidgetHeading { get; set; }

        public TableWidgetViewModel Initialise(string[] clientColumns, string heading, string tableId, params string[] columnHeadings)
        {
            ClientColumns = clientColumns;
            TableId = tableId;
            WidgetHeading = heading;
            Columns = columnHeadings.ToList();

            return this;
        }

        public MvcHtmlString RenderColumns()
        {
            var builder = new StringBuilder();
            foreach (var column in Columns)
            {
                builder.AppendFormat("<th>{0}</th>", column);
                builder.AppendLine();
            }

            var content = WrapColumns(builder.ToString());
            return content.ToHtmlString();
        }

        public MvcHtmlString RenderClientColumnScript()
        {
            if (ClientColumns == null || ClientColumns.Count == 0)
            {
                return MvcHtmlString.Empty;
            }

            var scriptBuilder = new StringBuilder();
            scriptBuilder.AppendLine("\"columns\": [");

            var scriptItems = ClientColumns.Select(WrapClientColumn).ToArray();
            var columnScript = string.Join(", ", scriptItems);
            scriptBuilder.AppendLine(columnScript);
            scriptBuilder.AppendLine("],");
            return scriptBuilder.ToHtmlString();
        }

        private static string WrapClientColumn(string columnName)
        {
            return string.Concat("{ \"data\": \"", columnName, "\" }");
        }

        private static string WrapColumns(string columnContent)
        {
            return string.Concat("<tr>", columnContent, "</tr>");
        }
    }
}