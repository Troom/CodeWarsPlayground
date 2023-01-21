using System.Numerics;

namespace CodeWarsPlayground.CSharp.Kyu4
{
    internal static class SumStringsAsNumbers
    {

        public static string sumStrings(string a, string b)
        {
            if (string.IsNullOrEmpty(a))
                a = "0";
            if (string.IsNullOrEmpty(b))
                b = "0";
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }

        public static string sumStringsTryParse(string a, string b)
        {
            BigInteger.TryParse(a, out BigInteger bigA);
            BigInteger.TryParse(b, out BigInteger bigB);

            return (bigA + bigB).ToString();
        }

    }
}
