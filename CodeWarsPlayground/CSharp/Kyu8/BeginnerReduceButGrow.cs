namespace CodeWarsPlayground.CSharp.Kyu8
{
    internal class BeginnerReduceButGrow
    {
        public static int Grow(int[] x)
        {
            int result = 1;
            for (int i = 0; i < x.Length; i++)
            {
                result = result * x[i];
            }
            return result;
        }

        public static int GrowAggregate(int[] x) //Worst performace
        {
            return x.Aggregate((a, b) => a * b);
        }
    }
}
