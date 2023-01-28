using System.Dynamic;

namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal static class Multiples_of_3_or_5
    {
        public static int Solution(int value)
        {
            value = 20;
            int result = 0;
            do
            {
                value--;
                if (value % 5 == 0)
                { 
                    result += value;
                    continue;
                }

                if (value % 3 == 0)
                    result += value;
            } while (value > 2);

            return result;
        }


        public static int SolutionRange(int n)
        {
            return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
    }
}