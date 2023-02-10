namespace CodeWarsPlayground.CSharp.Kyu7
{
    internal static class CenteredPentagonalNumber
    {
        //Math.Pow oparates on floating-point types, which are by definition inaccurate.
        public static long Pentagonal(long n) => n > 0 ? (5 * n * n - 5 * n + 2) / 2 : -1;
    }
}
