namespace CodeWarsPlayground.CSharp.Kyu7
{
    internal static class OrderedCountOfCharacters
    {

        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            var tmp = new Dictionary<char, int>();
            var result = new List<Tuple<char, int>>();
            foreach (var item in input)
            {
                if (tmp.ContainsKey(item))
                {
                    tmp[item]++;
                }
                else { 
                tmp.Add(item, 1);
                }
            }
            foreach (var item in tmp)
            {
                result.Add(new Tuple<char, int>(item.Key, item.Value));
            }

            return result;
        }


        public static List<Tuple<char, int>> OrderedCountLinq(string input)
        {
            return input
                    .GroupBy(x => x)
                    .Select(x => Tuple.Create(x.Key, x.Count()))
                    .ToList();
        }


        public static IEnumerable<Tuple<char, int>> OrderedCountGroupBy(string input)
        {
            return input.GroupBy(x => x, (c, g) => (c, g.Count()).ToTuple());
        }

    }
}
