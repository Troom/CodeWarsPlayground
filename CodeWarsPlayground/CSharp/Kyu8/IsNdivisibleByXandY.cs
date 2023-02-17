namespace CodeWarsPlayground.CSharp.Kyu8
{
    internal class IsNdivisibleByXandY
    {
        public static bool IsDivisible(int n, int x, int y) => n % x == 0 && n % y == 0 ? true : false;
    }
}
