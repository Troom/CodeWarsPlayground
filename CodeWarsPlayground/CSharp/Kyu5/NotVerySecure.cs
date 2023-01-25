using System.Text.RegularExpressions;

namespace CodeWarsPlayground.CSharp.Kyu5
{
    internal static class NotVerySecure
    {
        public static bool Alphanumeric(string str) => !string.IsNullOrEmpty(str) ? new Regex("^[a-zA-Z0-9]*$").IsMatch(str) : false;
        public static bool AlphanumericWithoutRegex(string str)
        {
            return str.All(c => Char.IsLetterOrDigit(c)) && !string.IsNullOrEmpty(str);
        }
    }
}
