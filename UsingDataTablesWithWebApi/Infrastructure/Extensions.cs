namespace Levelnis.Learning.UsingDataTablesWithWebApi.Infrastructure
{
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
    }
}