
namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static class HammingDistance
    {
        public static int Distance(string a, string b)
        {
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    result++;
            }
            return result;
        }
    }
}
