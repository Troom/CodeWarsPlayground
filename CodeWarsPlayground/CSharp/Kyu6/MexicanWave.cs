using System.Text;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static class MexicanWave
    {

        public static List<string>  wave(string str)
        {
            var result = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Clear();

                if (str[i] == ' ')
                {
                    sb.Append(" ");
                    continue;
                }
                for (int j = 0; j < i; j++)
                {
                    sb.Append(str[j]);
                }
                sb.Append(char.ToUpper(str[i]));
                for (int j = i+1; j < str.Length; j++)
                {
                    sb.Append(str[j]);
                }
                result.Add(sb.ToString());
            }
            return result;
        }

        public static List<string> waveLinq(string str) =>
                      str
                        .Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
                        .Where(x => x != str)
                        .ToList();


        public static List<string> waveEnumberableLinq(string str) => new List<string>(Enumerable.Range(0, str.Length).Where(index => str[index] != ' ').Select(index => new string (str.Select((ch, i) => index == i? char.ToUpper(ch) : ch).ToArray())));

    }
}
