namespace CodeWarsPlayground.CSharp.Kyu7
{
    internal static class You_reASquare_
    {
        public static bool IsSquare(int n) => Int32.TryParse(Math.Sqrt(n).ToString(), out int result);
    }
}
