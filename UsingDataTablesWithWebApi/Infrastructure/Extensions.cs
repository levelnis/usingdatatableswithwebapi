namespace Levelnis.Learning.UsingDataTablesWithWebApi.Infrastructure
{
    using System.Text;
    using System.Web.Mvc;

    public static class Extensions
    {
        public static string AsPropertyName(this string source)
        {
            return char.ToUpper(source[0]) + source.Substring(1);
        }

        public static bool ContainsIgnoringCase(this string source, string substring)
        {
            return source.ToLower().Contains(substring.ToLower());
        }

        public static MvcHtmlString ToHtmlString(this string source)
        {
            return MvcHtmlString.Create(source);
        }

        public static MvcHtmlString ToHtmlString(this StringBuilder source)
        {
            return source.ToString().ToHtmlString();
        }
    }
}