using System.Text;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static class FormatWordsIntoASentence
    {
        public static string FormatWords(string[] words)
        {
            if (words == null)
            {
                return "";
            }
            words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            var sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0 || sb.Length == 0)
                {
                    sb.Append(words[i]);
                    continue;
                }

                if (i < words.Length - 1)
                {
                    if (!string.IsNullOrEmpty(words[i]))
                    {
                        sb.Append(", " + words[i]);
                    }
                }
                else
                {
                    sb.Append(" and " + words[i]);
                }
            }
            return sb.ToString();
        }
    }
}