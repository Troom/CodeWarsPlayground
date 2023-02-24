using System.Text;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static  class ConsecutiveStrings
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            strarr = strarr.Distinct().ToArray();
            if (k <= 0 || strarr.Length == 0 || strarr.Length < k)
                return "";

            var sb = new StringBuilder();
            List<string> list = new List<string>();

            for (int i = 0; i < strarr.Length; i++)
            {
                if (i + k > strarr.Length)
                    break;

                for (int j = i; j < i + k; j++)
                    sb.Append(strarr[j]);

                list.Add(sb.ToString());
                sb.Clear();
            }
            return list.OrderByDescending(x => x.Length).FirstOrDefault();
        }
    }
}
