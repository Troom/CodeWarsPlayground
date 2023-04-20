namespace CodeWarsPlayground.CSharp.Kyu7
{
    internal static class ChainMe
    {
        public static double Chain(double input, Func<double, double>[] fs)
        {
            foreach (var f in fs)
            {
                input = f.Invoke(input);
            }
            return input;
        }

        public static double ChainAggregate(double input, Func<double, double>[] fs)
        {
            return fs.Aggregate(input, (current, t) => t(current));
        }

    }
}
