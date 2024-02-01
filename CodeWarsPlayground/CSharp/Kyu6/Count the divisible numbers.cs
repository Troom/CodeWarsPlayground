namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static class Count_the_divisible_numbers
    {
        public static long DivisibleCount(long x, long y, long k)
        {
            int result = 0;
            for (int i = (int)x; i < y; i++)
            {
                if (i % k == 0)
                {
                    result++;
                }
            }
            return result;
        }


        public static long DivisibleCountBetterPerformance(long x, long y, long k) => y / k - x / k + (x % k == 0 ? 1 : 0);
    }
}
