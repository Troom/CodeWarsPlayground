namespace CodeWarsPlayground.CSharp.Kyu6
{
    internal class PairOfGloves
    {
        public static int NumberOfPairs(string[] gloves)
        {
            var tmp = new Dictionary<string, int>();
            int counter = 0;

            foreach (var item in gloves)
            {
                if (tmp.ContainsKey(item))
                    tmp[item]++;
                else
                    tmp.Add(item, 1);
            }


            foreach (var item in tmp)
            {
                if (item.Value / 2 > 0)
                    counter += item.Value / 2;
            }
            return counter;
        }

        public static int NumberOfPairsLinq(string[] gloves)
        {
            return gloves.GroupBy(p => p).Select(q => q.Count() / 2).Sum();
        }

    }
}
