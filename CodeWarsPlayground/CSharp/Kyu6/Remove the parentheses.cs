using System.Text.RegularExpressions;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static class Remove_the_parentheses
    {
            public static string RemoveParentheses(string s)
            {
                do
                    s = Regex.Replace(s, @"\([^()]*\)", string.Empty);
                while 
                    (s.Contains("(") || s.Contains("}"));
                return s;
            }

            public static string RemoveParenthesesRecursion(string s)
                             => s.Contains('(') ? RemoveParenthesesRecursion(Regex.Replace(s, @"\([^()]*\)", "")) : s;

    }
}
