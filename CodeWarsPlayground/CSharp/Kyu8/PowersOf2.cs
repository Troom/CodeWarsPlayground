using System.Numerics;

namespace CodeWarsPlayground.CSharp.Kyu8
{
    public static class PowersOf2
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            List<BigInteger> result = new List<BigInteger>();
            for (int i = 0; i <= n; i++)
            {
                result.Add((BigInteger)Math.Pow(2, i));
            }
            return result.ToArray();
        }
    }
}
